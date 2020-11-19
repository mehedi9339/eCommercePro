using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using eCommerce.Context;
using eCommerce.Models;
using System;

namespace eCommerce.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly databaseContext _context;

        public ProductsController(databaseContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            try
            {
                return await _context.Products.ToListAsync();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.ProductId)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                if (await _context.SaveChangesAsync() >= 0)
                {
                    return Ok(product);
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
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

        // POST: api/Products
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    // Add product to product table
                    product.Status = Enums.ProductStatus.Available;
                    _context.Products.Add(product);
                    await _context.SaveChangesAsync();

                    // Create a row in stock
                    var stock = new Stock
                    {
                        StockId = 0,
                        ProductCode = product.ProductCode,
                        InStockQuantity = 0,
                        LotNo = 0
                    };
                    _context.Stocks.Add(stock);
                    await _context.SaveChangesAsync();

                    // Create stock detail
                    //var stockDetails = new StockDetails
                    //{
                    //    StockDetailsId = 0,
                    //    StockId = (from s in _context.Stocks
                    //               where s.ProductCode == product.ProductCode
                    //               select s.StockId).FirstOrDefault(),
                    //    StockDate = DateTime.Now,
                    //    InQuantity = 0,
                    //    OutQuantity = 0,
                    //    StockPrice = 0,
                    //    BalancedQuantity = 30
                    //};
                    //_context.StockDetails.Add(stockDetails);
                    //await _context.SaveChangesAsync();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    ModelState.AddModelError("", ex.Message);
                }
            }

            return CreatedAtAction("GetProduct", new { id = product.ProductId }, product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return product;
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
