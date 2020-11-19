
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using eCommerce.Context;
using System;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using eCommerce.Models;

namespace eCommerce.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseMastersController : ControllerBase
    {
        private readonly databaseContext _context;

        public PurchaseMastersController(databaseContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseMasters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchaseMaster>>> GetPurchaseMasters()
        {
            try
            {
                return await _context.PurchaseMasters.ToListAsync();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // GET: api/PurchaseMasters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseMaster>> GetPurchaseMaster(int id)
        {
            var purchaseMaster = await _context.PurchaseMasters.FindAsync(id);

            if (purchaseMaster == null)
            {
                return NotFound();
            }

            return purchaseMaster;
        }

        // PUT: api/PurchaseMasters/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseMaster(int id, PurchaseMaster purchaseMaster)
        {
            if (id != purchaseMaster.PurchaseMasterId)
            {
                return BadRequest();
            }

            try
            {
                _context.Entry(purchaseMaster).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return NoContent();
        }

        // POST: api/PurchaseMasters
        //[HttpPost]
        //public async Task<ActionResult<PurchaseMaster>> PostPurchaseMaster(PurchaseMaster purchaseMaster)
        //{
        //    try
        //    {
        //        _context.PurchaseMasters.Add(purchaseMaster);
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        ModelState.AddModelError("", ex.Message);
        //    }

        //    return CreatedAtAction("GetPurchaseMaster", new { id = purchaseMaster.PurchaseMasterId }, purchaseMaster);
        //}

        //[HttpPost]
        //public async Task<ActionResult<PurchaseMaster>> PostPurchaseMaster(PurchaseMaster purchaseMaster)
        //{
        //    using (var transaction = _context.Database.BeginTransaction())
        //    {
        //        try
        //        {
        //            //Get logged in userId
        //            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        //            //var roles = await _userManager.GetRolesAsync(userId);

        //            // Check user is logged in or not
        //            if (userId != null)
        //            {
        //                // Create PurchaseMaster
        //                var pMaster = new PurchaseMaster
        //                {
        //                    PurchaseMasterId = 0,
        //                    PurchaseDate = DateTime.Now,
        //                    TotalQuantity = purchaseMaster.TotalQuantity,
        //                    TotalPrice = purchaseMaster.TotalPrice,
        //                    DiscountRate = purchaseMaster.DiscountRate,
        //                    VatRate = purchaseMaster.VatRate,
        //                    LaborCost = purchaseMaster.LaborCost,
        //                    VoucharNo = purchaseMaster.VoucharNo,
        //                    BillNo = purchaseMaster.BillNo,
        //                    Note = purchaseMaster.Note,
        //                    NetAmount = purchaseMaster.NetAmount
        //                };
        //                _context.PurchaseMasters.Add(pMaster);
        //                await _context.SaveChangesAsync();

        //                PurchaseMaster pM = new PurchaseMaster();
        //                foreach (var item in purchaseMaster.PurchaseDetails)
        //                {
        //                    // Check existance of Product in PurchaseDetails
        //                    var pIdInPDetails = (from d in _context.PurchaseDetails
        //                                           where d.ProductCode == item.ProductCode
        //                                           select d.PurchaseDetailId).FirstOrDefault();


        //                    if (pIdInPDetails == 0)
        //                    {
        //                        item.MasterId = pMaster.PurchaseMasterId;
        //                        item.EntryDate = pMaster.PurchaseDate;
        //                        _context.PurchaseDetails.Add(item);
        //                    }
        //                    else
        //                    {
        //                        PurchaseDetail pd = new PurchaseDetail();
        //                        pd = _context.PurchaseDetails.Find(pIdInPDetails);
        //                        pd.MasterId = pMaster.PurchaseMasterId;
        //                        pd.EntryDate = pMaster.PurchaseDate;
        //                        _context.Entry(pd).State = EntityState.Modified;
        //                    }
        //                    await _context.SaveChangesAsync();

        //                    var pCode = (from p in _context.Products
        //                                 where p.ProductId == item.ProductId
        //                                 select p.ProductCode).FirstOrDefault();

        //                    var stId = (from s in _context.Stocks
        //                                where s.ProductCode == pCode
        //                                select s.StockId).FirstOrDefault();

        //                    //var sdetailsId = (from w in _context.StockDetails
        //                    //                  where w.StockId == stId
        //                    //                  select w.StockDetailsId).FirstOrDefault();

        //                    // Update InQuantity from StockDetails Table
        //                    //StockDetails stockDetails = new StockDetails();
        //                    //stockDetails = _context.StockDetails.Find(sdetailsId);
        //                    //stockDetails.InQuantity += item.UnitQuantity;
        //                    //_context.Entry(stockDetails).State = EntityState.Modified;
        //                    //await _context.SaveChangesAsync();

        //                    var inOut = (from st in _context.Stocks
        //                                 where st.StockId == stId
        //                                 select new
        //                                 {
        //                                     st.InQuantity,
        //                                     st.OutQuantity
        //                                 }).FirstOrDefault();

        //                    // Update InStockQuantity from Stock Table
        //                    Stocks stock = new Stocks();
        //                    //stock = _context.Stocks.Find(stId);
        //                    stock.InStockQuantity = inOut.InQuantity - inOut.OutQuantity;
        //                    _context.Entry(stock).State = EntityState.Modified;
        //                    await _context.SaveChangesAsync();

        //                    //Find ProductId
        //                    var pid = (from p in _context.Products
        //                               where p.ProductCode == pCode
        //                               select p.ProductId).FirstOrDefault();

        //                    //Set ProductStatus to Available
        //                    Product prd = new Product();
        //                    prd = _context.Products.Find(pid);
        //                    prd.Status = Enums.ProductStatus.Available;
        //                    _context.Entry(prd).State = EntityState.Modified;
        //                    await _context.SaveChangesAsync();
        //                }
        //                transaction.Commit();
        //                return Ok("PurchaseMaster completed.\nUser id is " + userId);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            await transaction.RollbackAsync();
        //            ModelState.AddModelError("", ex.Message);
        //            return BadRequest(ModelState);
        //        }
        //    }
        //    return BadRequest();
        //}

        [HttpPost]
        public async Task<ActionResult<PurchaseMaster>> PostPurchaseMaster(PurchaseMaster purchaseMaster)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    //Get logged in userId
                    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                    //var roles = await _userManager.GetRolesAsync(userId);

                    // Check user is logged in or not
                    if (userId != null)
                    {
                        // Create PurchaseMaster
                        var pMaster = new PurchaseMaster
                        {
                            PurchaseMasterId = 0,
                            PurchaseDate = DateTime.Now,
                            TotalQuantity = purchaseMaster.TotalQuantity,
                            TotalPrice = purchaseMaster.TotalPrice,
                            DiscountRate = purchaseMaster.DiscountRate,
                            VatRate = purchaseMaster.VatRate,
                            LaborCost = purchaseMaster.LaborCost,
                            VoucharNo = purchaseMaster.VoucharNo,
                            BillNo = purchaseMaster.BillNo,
                            Note = purchaseMaster.Note,
                            NetAmount = purchaseMaster.NetAmount
                        };
                        _context.PurchaseMasters.Add(pMaster);
                        await _context.SaveChangesAsync();

                        PurchaseMaster pM = new PurchaseMaster(); // s
                        int totalQty = 0;
                        decimal totalPrice = 0;
                        decimal totalNetAmount = 0;
                        foreach (var item in purchaseMaster.PurchaseDetails)
                        {
                            if (item.ExpiryDate == null)
                            {
                                item.ExpiryDate = DateTime.Now.AddYears(2); //s
                            }
                            else
                            {
                                item.ExpiryDate = DateTime.Now.AddYears(5); //s
                            }
                            item.MasterId = pMaster.PurchaseMasterId;
                            item.EntryDate = pMaster.PurchaseDate;
                            item.EntryBy = Guid.Parse(userId);
                            item.EntryDate = pMaster.PurchaseDate;
                           _context.PurchaseDetails.Add(item);
                            await _context.SaveChangesAsync();

                            var pdId = (from w in _context.PurchaseDetails
                                        where w.ProductCode == item.ProductCode
                                        orderby w.PurchaseDetailId descending
                                        select w.PurchaseDetailId).FirstOrDefault();

                            PurchaseDetail purchaseDetail = new PurchaseDetail();
                            purchaseDetail = _context.PurchaseDetails.Find(pdId);
                            purchaseDetail.TotalPrice = item.UnitPrice * item.UnitQuantity;
                            _context.Entry(purchaseDetail).State = EntityState.Modified;
                            await _context.SaveChangesAsync();

                            PurchaseDetail purchaseDetail1 = new PurchaseDetail();
                            purchaseDetail1 = _context.PurchaseDetails.Find(pdId);
                            // NetAmount = TotalAmount - Discount + Vat
                            purchaseDetail1.NetAmount = purchaseDetail.TotalPrice - (purchaseDetail.TotalPrice * item.DiscountRate / 100) + (purchaseDetail.TotalPrice * item.VatRate / 100);
                            _context.Entry(purchaseDetail1).State = EntityState.Modified;
                            await _context.SaveChangesAsync();

                            //check existance of the product in stock
                            var stockId = (from s in _context.Stocks
                                           where s.ProductCode == item.ProductCode
                                           select s.StockId).FirstOrDefault();

                            totalQty += item.UnitQuantity;
                            totalPrice += purchaseDetail.TotalPrice;
                            totalNetAmount += purchaseDetail.NetAmount;

                            // if is not in stock
                            if (stockId == 0)
                            {
                                var stock = new Stock
                                {
                                    StockId = 0,
                                    StockDate = pMaster.PurchaseDate,
                                    ProductCode = item.ProductCode,
                                    ModelId = item.ModelId,
                                    ColorId = item.ColorId,
                                    SizeId = item.SizeId,
                                    InQuantity = item.UnitQuantity,
                                    OutQuantity = 0,
                                    InStockQuantity = item.UnitQuantity,
                                    ExpiryDate = item.ExpiryDate,
                                };
                                _context.Stocks.Add(stock);
                                await _context.SaveChangesAsync();

                                Stock stock1 = new Stock();
                                stock1 = _context.Stocks.Find(stock.StockId);
                                stock1.ExpiryDate = item.ExpiryDate;
                                stock1.PurchasePrice = item.UnitPrice;
                                stock1.SalesPrice = item.SalesPrice;
                                stock1.StockPrice = stock.InQuantity * item.UnitPrice;
                                stock1.LotNo = 1;
                                _context.Entry(stock1).State = EntityState.Modified;
                                await _context.SaveChangesAsync();
                            }
                            // if is in stock
                            else
                            {
                                var checkActualPrdInStock = (from a in _context.Stocks
                                                             where a.ExpiryDate.Date == item.ExpiryDate.Date &&
                                                             a.PurchasePrice == item.UnitPrice &&
                                                             a.ModelId == item.ModelId &&
                                                             a.SizeId == item.SizeId &&
                                                             a.ColorId == item.ColorId &&
                                                             a.SalesPrice == item.SalesPrice
                                                             select a.StockId).FirstOrDefault();

                                if (checkActualPrdInStock == 0)
                                {
                                    var lotNo = (from l in _context.Stocks
                                                 where l.ProductCode == item.ProductCode
                                                 orderby l.StockId descending
                                                 select l.LotNo).FirstOrDefault();

                                    var stock = new Stock
                                    {
                                        StockId = 0,
                                        StockDate = pMaster.PurchaseDate,
                                        ProductCode = item.ProductCode,
                                        ModelId = item.ModelId,
                                        ColorId = item.ColorId,
                                        SizeId = item.SizeId,
                                        InQuantity = item.UnitQuantity,
                                        OutQuantity = 0,
                                        InStockQuantity = item.UnitQuantity,
                                        ExpiryDate = item.ExpiryDate,
                                    };
                                    _context.Stocks.Add(stock);
                                    await _context.SaveChangesAsync();

                                    Stock stock1 = new Stock();
                                    stock1 = _context.Stocks.Find(stock.StockId);
                                    stock1.ExpiryDate = item.ExpiryDate;
                                    stock1.PurchasePrice = item.UnitPrice;
                                    stock1.SalesPrice = item.SalesPrice;
                                    stock1.StockPrice = stock.InQuantity * item.UnitPrice;
                                    stock1.LotNo = lotNo + 1;
                                    _context.Entry(stock1).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();
                                }
                                else
                                {
                                    var inOut = (from st in _context.Stocks
                                                 where st.StockId == checkActualPrdInStock
                                                 select new
                                                 {
                                                     st.InQuantity,
                                                     st.OutQuantity,
                                                     st.InStockQuantity
                                                 }).FirstOrDefault();

                                    Stock stock1 = new Stock();
                                    stock1 = _context.Stocks.Find(stockId);
                                    stock1.InQuantity = inOut.InQuantity + item.UnitQuantity;
                                    stock1.InStockQuantity = inOut.InStockQuantity + item.UnitQuantity;
                                    stock1.ExpiryDate = item.ExpiryDate;
                                    _context.Entry(stock1).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();

                                    //Find ProductId
                                    var pid = (from p in _context.Products
                                                where p.ProductCode == item.ProductCode
                                                select p.ProductId).FirstOrDefault();

                                    //Set ProductStatus to Available
                                    Product prd = new Product();
                                    prd = _context.Products.Find(pid);
                                    prd.Status = Enums.ProductStatus.Available;
                                    _context.Entry(prd).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();

                                    var getPurchasePrice = (from p in _context.Stocks
                                                            where p.StockId == checkActualPrdInStock
                                                            select p.PurchasePrice).FirstOrDefault();

                                    Stock stock2 = new Stock();
                                    stock2 = _context.Stocks.Find(stockId);
                                    stock2.StockPrice = getPurchasePrice * stock1.InStockQuantity;
                                    _context.Entry(stock2).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();
                                }
                            }
                            PurchaseMaster purchaseMaster1 = new PurchaseMaster();
                            purchaseMaster1 = _context.PurchaseMasters.Find(pMaster.PurchaseMasterId);
                            purchaseMaster1.TotalQuantity = totalQty;
                            purchaseMaster1.TotalPrice = totalPrice;
                            purchaseMaster1.NetAmount = totalNetAmount;
                            _context.Entry(purchaseMaster1).State = EntityState.Modified;
                            await _context.SaveChangesAsync();

                            var grp = (from g in _context.Stocks
                                       where g.ProductCode == item.ProductCode
                                       group g by g.ProductCode into groupResult
                                       select new
                                       {
                                           ProductCode = groupResult.Key,
                                           SalesPrice = groupResult.Average(f => f.SalesPrice)
                                       }).FirstOrDefault();
                            var prdId = (from p in _context.Products
                                         where p.ProductCode == item.ProductCode
                                         select p.ProductId).FirstOrDefault();
                            var dsicount = (from d in _context.Products
                                            where d.ProductId == prdId
                                            select d.DiscountRate).FirstOrDefault();

                            Product product = new Product();
                            product = _context.Products.Find(prdId);
                            product.SalesPrice = grp.SalesPrice;
                            product.PreviousPrice = grp.SalesPrice + (grp.SalesPrice * 8 / 100);
                            _context.Entry(product).State = EntityState.Modified;

                            await _context.SaveChangesAsync();
                        }

                        transaction.Commit();
                        return Ok("Purchase completed.\nUser id is " + userId);
                    }
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    ModelState.AddModelError("", ex.Message);
                    return BadRequest(ModelState);
                }
            }
            return BadRequest();
        }

        // DELETE: api/PurchaseMasters/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PurchaseMaster>> DeletePurchaseMaster(int id)
        {
            var purchaseMaster = await _context.PurchaseMasters.FindAsync(id);
            if (purchaseMaster == null)
            {
                return NotFound();
            }

            try
            {
                _context.PurchaseMasters.Remove(purchaseMaster);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return purchaseMaster;
        }

        private bool PurchaseMasterExists(int id)
        {
            return _context.PurchaseMasters.Any(e => e.PurchaseMasterId == id);
        }
    }
}
