using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using eCommerce.Context;
using eCommerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private readonly databaseContext _context;
        private readonly UserManager<User> _userManager;
        public ProductDetailsController(databaseContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<ActionResult<WishList>> AddToWishList(int qty, int id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //Get Product
                    var prd = _context.Products.Find(id);

                    //Get Logged in User
                    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                    //Check if user is Logged in or not
                    if (userId != null)
                    {
                        //Get customer id based on userId
                        var customerId = _context.Customer.Where(c => c.UserId.ToString() == userId).Select(s => s.CustomerId).FirstOrDefault();

                        //Check stock
                        var isInStock = _context.Stocks.Where(s => s.ProductCode == prd.ProductCode).Select(p => p.InStockQuantity).FirstOrDefault();

                        //If stock is not available, add to wishList
                        if (isInStock < qty)
                        {
                            var wList = new WishList
                            {
                                WishListId = 0,
                                CustomerId = customerId,
                                ProductId = prd.ProductId,
                                Quantity = qty
                            };
                            _context.WisthLists.Add(wList);
                            await _context.SaveChangesAsync();
                            return Ok();
                        }
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return BadRequest(ModelState);
                }
            }
            return BadRequest();
        }
    }
}