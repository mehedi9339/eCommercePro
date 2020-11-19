using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using eCommerce.Context;
using System.Security.Claims;
using eCommerce.Models;

namespace eCommerce.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseDetailsController : ControllerBase
    {
        private readonly databaseContext _context;

        public PurchaseDetailsController(databaseContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchaseDetail>>> GetPurchaseDetails()
        {
            try
            {
                return await _context.PurchaseDetails.ToListAsync();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // GET: api/PurchaseDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseDetail>> GetPurchaseDetail(int id)
        {
            var purchaseDetail = await _context.PurchaseDetails.FindAsync(id);

            if (purchaseDetail == null)
            {
                return NotFound();
            }

            return purchaseDetail;
        }

        // PUT: api/PurchaseDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseDetail(int id, PurchaseDetail purchaseDetail)
        {
            if (id != purchaseDetail.PurchaseDetailId)
            {
                return BadRequest();
            }

            _context.Entry(purchaseDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseDetailExists(id))
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

        // POST: api/PurchaseDetails
        [HttpPost]
        public async Task<ActionResult<PurchaseDetail>> PostPurchaseDetail(PurchaseDetail purchaseDetail)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    purchaseDetail.EntryBy = Guid.Parse(userId);

                    // Save to PurchaseDetail Table
                    _context.PurchaseDetails.Add(purchaseDetail);
                    await _context.SaveChangesAsync();

                    // Find StockId by ProductCode
                    var stokId = (from s in _context.Stocks
                                  where s.ProductCode == purchaseDetail.ProductCode
                                  select s.StockId).FirstOrDefault();
                    if (stokId != 0)
                    {
                        // Find StockDetailsId by stockId
                        var sdId = (from sd in _context.Stocks
                                    where sd.StockId == stokId
                                    select sd.StockId).FirstOrDefault();

                        // Update StockDetails Table
                        //StockDetails stockDetails = new StockDetails();
                        //stockDetails = _context.Stocks.Find(sdId);
                        //stockDetails.InQuantity += purchaseDetail.UnitQuantity;
                        //stockDetails.StockDate = DateTime.Now;
                        //_context.Entry(stockDetails).State = EntityState.Modified;
                        //await _context.SaveChangesAsync();

                        // Find inQuantity and outQuantity
                        var Qty = (from d in _context.Stocks
                                   where d.StockId == stokId
                                   select new
                                   {
                                       d.InQuantity,
                                       d.OutQuantity
                                   }).FirstOrDefault();

                        // Update inStockQuantity in Stock Table
                        //Stocks stocks = new Stocks();
                        //stocks = _context.Stocks.Find(stokId);
                        //stocks.InStockQuantity = Qty.InQuantity - Qty.OutQuantity;

                        //_context.Entry(stocks).State = EntityState.Modified;
                        //await _context.SaveChangesAsync();

                        // Find Product Id By Product Code
                        var prdId = (from p in _context.PurchaseDetails
                                     where p.ProductCode == purchaseDetail.ProductCode
                                     select p.ProductId).FirstOrDefault();

                        // Update product table
                        Product product = new Product();
                        product = _context.Products.Find(prdId);
                        product.DiscountRate = purchaseDetail.DiscountRate;
                        product.ProductDescription = purchaseDetail.Description;
                        _context.Entry(product).State = EntityState.Modified;
                        await _context.SaveChangesAsync();

                        //Update StockPrice
                        //var stockDetailsId = (from t in _context.StockDetails
                        //                      where t.StockId == stocks.StockId
                        //                      select t.StockDetailsId).FirstOrDefault();
                        //StockDetails sdt = new StockDetails();
                        //sdt = _context.StockDetails.Find(stockDetailsId);
                        //sdt.StockPrice = stocks.InStockQuantity * product.SalesPrice;
                        //sdt.InQuantity = stockDetails.InQuantity + purchaseDetail.UnitQuantity;
                        //_context.Entry(sdt).State = EntityState.Modified;
                        //await _context.SaveChangesAsync();
                        return Ok();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    ModelState.AddModelError("", ex.Message);
                    return BadRequest(ModelState);
                }
            }
            

            return CreatedAtAction("GetPurchaseDetail", purchaseDetail);
        }

        // DELETE: api/PurchaseDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PurchaseDetail>> DeletePurchaseDetail(int id)
        {
            var purchaseDetail = await _context.PurchaseDetails.FindAsync(id);
            if (purchaseDetail == null)
            {
                return NotFound();
            }

            _context.PurchaseDetails.Remove(purchaseDetail);
            await _context.SaveChangesAsync();

            return purchaseDetail;
        }

        private bool PurchaseDetailExists(int id)
        {
            return _context.PurchaseDetails.Any(e => e.PurchaseDetailId == id);
        }
    }
}
