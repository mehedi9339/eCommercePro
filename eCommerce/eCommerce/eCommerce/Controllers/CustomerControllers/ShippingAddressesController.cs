using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using eCommerce.Context;
using System.Security.Claims;
using System;
using eCommerce.Models;

namespace eCommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingAddressesController : ControllerBase
    {
        private readonly databaseContext _context;
        public ShippingAddressesController(databaseContext context)
        {
            _context = context;
        }

        // GET: api/ShippingAddresses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShippingAddress>>> GetShippingAddresses()
        {
            try
            {
                return await _context.ShippingAddresses.ToListAsync();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // GET: api/ShippingAddresses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShippingAddress>> GetShippingAddress(int id)
        {
            var shippingAddress = await _context.ShippingAddresses.FindAsync(id);

            if (shippingAddress == null)
            {
                return NotFound();
            }

            return shippingAddress;
        }

        // PUT: api/ShippingAddresses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShippingAddress(int id, ShippingAddress shippingAddress)
        {
            if (id != shippingAddress.ShippingAddressId)
            {
                return BadRequest();
            }

            _context.Entry(shippingAddress).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShippingAddressExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ShippingAddresses
        [HttpPost]
        public async Task<ActionResult<ShippingAddress>> PostShippingAddress(ShippingAddress shippingAddress)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    //Get logged in userId
                    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                    // Check user is logged in or not
                    if (userId != null)
                    {
                        //Get customerId by userId
                        var customerId = _context.Customer.Where(c => c.UserId.ToString() == userId).Select(s => s.CustomerId).FirstOrDefault();

                        // Add customer shippingAddress
                        shippingAddress.CustomerId = customerId;

                        _context.ShippingAddresses.Add(shippingAddress);
                        await _context.SaveChangesAsync();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    ModelState.AddModelError("", ex.Message);
                }
            }

            return CreatedAtAction("GetShippingAddress", new { id = shippingAddress.ShippingAddressId }, shippingAddress);
        }

        // DELETE: api/ShippingAddresses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ShippingAddress>> DeleteShippingAddress(int id)
        {
            var shippingAddress = await _context.ShippingAddresses.FindAsync(id);
            if (shippingAddress == null)
            {
                return NotFound();
            }

            _context.ShippingAddresses.Remove(shippingAddress);
            await _context.SaveChangesAsync();

            return shippingAddress;
        }

        private bool ShippingAddressExists(int id)
        {
            return _context.ShippingAddresses.Any(e => e.ShippingAddressId == id);
        }
    }
}
