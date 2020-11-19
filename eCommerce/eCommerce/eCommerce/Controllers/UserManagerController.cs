using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Context;
using eCommerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using static eCommerce.ViewModels.dbViewModels;

namespace eCommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserManagerController : ControllerBase
    {
        private readonly databaseContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly JwtSettings _jwtSettings;
        public UserManagerController(UserManager<User> userM, RoleManager<Role> roleM, IOptionsSnapshot<JwtSettings> jwtSettings, databaseContext context)
        {
            this._userManager = userM;
            this._roleManager = roleM;
            _jwtSettings = jwtSettings.Value;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserVm vm, string userType)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    // Get user
                    var user = new User
                    {
                        UserName = vm.UserName,
                        Email = vm.Email
                    };
                    // Create user
                    var result = await _userManager.CreateAsync(user, vm.Password);
                    if (result.Succeeded)
                    {
                        // Check UserType
                        if (userType == "customer")
                        {
                            // Create customer
                            var customer = new Customer
                            {
                                UserId = user.Id,
                                DistrictId = 1,
                                ThanaId = 1
                            };
                            await _context.Customer.AddAsync(customer);
                            await _context.SaveChangesAsync();
                            Created("", vm);

                            //Assign user to Customer
                            var r = await _userManager.AddToRoleAsync(user, "Customer");

                            if (r.Succeeded)
                            {
                                await transaction.CommitAsync();
                                return Ok(user.Email + " assigned to Customer Role!");
                            }
                        }
                        //Check userType
                        else if (userType == "admin")
                        {
                            // Assign user to Admin
                            var r = await _userManager.AddToRoleAsync(user, "Admin");

                            if (r.Succeeded)
                            {
                                await transaction.CommitAsync();
                                return Ok();
                            }
                        }
                    }
                    else if (result.Errors.Count() > 0)
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
                catch (Exception er)
                {
                    await transaction.RollbackAsync();
                    ModelState.AddModelError("", er.Message);
                }
            }
            return Problem();
        }

        [HttpPost("CreateRoles")]
        public async Task<IActionResult> CreateRole(string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
            {
                return BadRequest("Role Name should be provided.");
            }
            var newRole = new Role
            {
                Name = roleName
            };
            var roleResult = await _roleManager.CreateAsync(newRole);
            if (roleResult.Succeeded)
            {
                return Ok();
            }
            return Problem(roleResult.Errors.First().Description, null, 500);
        }

        [HttpPost("SignIn")]
        public async Task<IActionResult> Login(UserVm userVm)
        {
            var user = _userManager.Users.Where(u => u.Email == userVm.Email).FirstOrDefault();
            if (user == null)
            { return NoContent(); }
            var result = await _userManager.CheckPasswordAsync(user, userVm.Password);
            if (result)
            {
                var roleList = await _userManager.GetRolesAsync(user);
                var token = GenerateJwt(user, roleList);

                return Ok(new { token});
            }
            return BadRequest();
        }

        private object GenerateJwt(User user, IList<string> roleList)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

            var roleClaims = roleList.Select(r => new Claim(ClaimTypes.Role, r));
            claims.AddRange(roleClaims);

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(Convert.ToDouble(_jwtSettings.ExpirationInDays));

            var token = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Issuer,
                claims,
                expires: expires,
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [HttpPost("AddRole")]
        public async Task<IActionResult> AddUserToRole(string userEmail, string roleName)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.Email == userEmail);

            var result = await _userManager.AddToRoleAsync(user, roleName);

            if (result.Succeeded)
            {
                return Ok();
            }

            return Problem(result.Errors.First().Description, null, 500);
        }

        [HttpGet("Users")]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            var users = await _userManager.Users.ToListAsync();
            return users;
        }

        [HttpGet("Roles")]
        public async Task<ActionResult<List<Role>>> GetRoles()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return roles;
        }
    }
}