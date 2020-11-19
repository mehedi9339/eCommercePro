using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using eCommerce.Context;
using eCommerce.Models;
using eCommerce.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static eCommerce.ViewModels.dbViewModels;

namespace eCommerce.Controllers.CustomerControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly databaseContext _context;
        public OrdersController(databaseContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            try
            {
                return await _context.Orders.ToListAsync();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // POST: api/Orders
        [HttpPost]
        public async Task<ActionResult<OrderVm>> Sales(OrderVm vm)
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
                        var lastNumber = (from l in _context.Orders
                                          where l.OrderId == (
                                            (from o in _context.Orders
                                             select o.OrderId).Max()
                                          )
                                          select l.OrderNo).FirstOrDefault();


                        // Generate order Number
                        var prefix = lastNumber.Substring(0, 3);
                        var suffix = lastNumber.Substring(3);
                        var ln = lastNumber.Substring(11);

                        var y = DateTime.Now.Year.ToString();
                        var m = DateTime.Now.Month.ToString();
                        var d = DateTime.Now.Day.ToString();

                        if (m.Length == 1)
                        {
                            m = "0" + m;
                        }
                        if (d.Length == 1)
                        {
                            d = "0" + d;
                        }

                        var sy = suffix.Substring(0, 4);
                        var sm = suffix.Substring(4, 2);
                        var sd = suffix.Substring(6, 2);

                        string newN;

                        if (sy == y && sm == m && sd.ToString() == d)
                        {

                            newN = prefix + y.ToString() + m.ToString() + d.ToString() + (Int32.Parse(ln) + 1).ToString();
                        }
                        else
                        {
                            newN = prefix + y.ToString() + m.ToString() + d.ToString() + "0";
                        };

                        // Create an order for the customer
                        var order = new Order
                        {
                            OrderId = 0,
                            OrderNo = newN,
                            ShippingAddressId = vm.Order.ShippingAddressId,
                            CustomerId = vm.Order.CustomerId,
                            OrderStatus = Enums.OrderStatus.Ordered,
                            OrderDate = DateTime.Now,
                            DeliveryStatus = Enums.DeliveryStatus.Pending,
                            DeliveryDate = DateTime.Now.AddDays(7),
                            ShippingDate = DateTime.Now.AddDays(2),
                            DeliveryFee = vm.Order.DeliveryFee,
                            PaymentStatus = true,
                            TransactionId = vm.Order.TransactionId,
                            TransactionTime = DateTime.Now,
                            TotalAmount = vm.Order.TotalAmount
                        };
                        _context.Orders.Add(order);
                        await _context.SaveChangesAsync();

                        // Create SalesMaster for the Order
                        var sMaster = new SalesMaster
                        {
                            SalesMasterId = 0,
                            OrderId = order.OrderId,
                            SalesDate = DateTime.Now,
                            TotalQuantity = vm.SalesMaster.TotalQuantity,
                            TotalPrice = vm.SalesMaster.TotalPrice,
                            VoucherNo = vm.SalesMaster.VoucherNo,
                            BillNo = vm.SalesMaster.BillNo,
                            TotalAmount = vm.SalesMaster.TotalAmount,
                            Note = vm.SalesMaster.Note
                        };
                        _context.SalesMasters.Add(sMaster);
                        await _context.SaveChangesAsync();

                        // Create SalesDetails with each Cart Items
                        SalesMaster salesMaster = new SalesMaster();
                        int totalQty = 0;
                        decimal totalAmount = 0;
                        foreach (var item in vm.SalesMaster.SalesDetails)
                        {
                            item.SalesMasterId = sMaster.SalesMasterId;
                            item.VatAmount = (item.UnitQuantity * item.UintPrice) * item.VatRate / 100;
                            item.DiscountAmount = (item.UnitQuantity * item.UintPrice) * item.DiscountRate / 100;
                            _context.SalesDetails.Add(item);
                            await _context.SaveChangesAsync();

                            SalesDetail salesDetail = new SalesDetail();
                            salesDetail = _context.SalesDetails.Find(item.SalesDetailId);
                            salesDetail.NetAmount = (item.UnitQuantity * item.UintPrice) + item.VatAmount - item.DiscountAmount;
                            _context.Entry(salesDetail).State = EntityState.Modified;
                            await _context.SaveChangesAsync();

                            var pCode = (from p in _context.Products
                                         where p.ProductId == item.ProductId
                                         select p.ProductCode).FirstOrDefault();


                            var exStId = (from s in _context.Stocks
                                          where s.ProductCode == pCode &&
                                          s.ColorId == item.ColorId &&
                                          s.SizeId == item.SizeId &&
                                          s.ModelId == item.ModelId &&
                                          //s.InStockQuantity > item.UnitQuantity &&
                                          s.ExpiryDate > DateTime.Now.AddMonths(2)
                                          //&& s.SalesPrice == item.Product.SalesPrice
                                          select new
                                          {
                                              s.StockId,
                                              s.InStockQuantity
                                          }).FirstOrDefault();

                            var exStId2 = (from s in _context.Stocks
                                           where s.ProductCode == pCode &&
                                           s.ColorId == item.ColorId &&
                                           s.SizeId == item.SizeId &&
                                           s.ModelId == item.ModelId &&
                                           //s.InStockQuantity > item.UnitQuantity &&
                                           s.ExpiryDate > DateTime.Now.AddMonths(2)
                                           //&& s.SalesPrice == item.Product.SalesPrice
                                           select new
                                           {
                                               s.StockId,
                                               s.InStockQuantity
                                           }).Skip(1).FirstOrDefault();

                            if (exStId.InStockQuantity >= item.UnitQuantity)
                            {
                                var inOut = (from st in _context.Stocks
                                             where st.StockId == exStId.StockId
                                             select new
                                             {
                                                 st.InQuantity,
                                                 st.OutQuantity
                                             }).FirstOrDefault();

                                Stock stock = new Stock();
                                stock = _context.Stocks.Find(exStId.StockId);
                                stock.OutQuantity = inOut.OutQuantity + item.UnitQuantity;
                                _context.Entry(stock).State = EntityState.Modified;
                                await _context.SaveChangesAsync();

                                Stock stock1 = new Stock();
                                stock1 = _context.Stocks.Find(exStId.StockId);
                                stock1.InStockQuantity = inOut.InQuantity - stock.OutQuantity;
                                _context.Entry(stock1).State = EntityState.Modified;
                                await _context.SaveChangesAsync();

                                Stock stock2 = new Stock();
                                stock2 = _context.Stocks.Find(exStId.StockId);
                                stock2.StockPrice = stock.PurchasePrice * stock1.InStockQuantity;
                                _context.Entry(stock2).State = EntityState.Modified;
                                await _context.SaveChangesAsync();

                                var inStQty = (from q in _context.Stocks
                                               where q.StockId == exStId.StockId
                                               select q.InStockQuantity).FirstOrDefault();

                                var pid = (from p in _context.Products
                                           where p.ProductCode == pCode
                                           select p.ProductId).FirstOrDefault();

                                if (inStQty <= 5)
                                {
                                    Product prd = new Product();
                                    prd = _context.Products.Find(pid);
                                    prd.Status = Enums.ProductStatus.NotAvailable;
                                    _context.Entry(prd).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();
                                }

                                totalQty += item.UnitQuantity;
                                totalAmount += salesDetail.NetAmount;

                                SalesMaster salesMaster1 = new SalesMaster();
                                salesMaster1 = _context.SalesMasters.Find(sMaster.SalesMasterId);
                                salesMaster1.TotalAmount = totalAmount;
                                salesMaster1.TotalQuantity = totalQty;
                                _context.Entry(salesMaster1).State = EntityState.Modified;
                                await _context.SaveChangesAsync();

                                Order order1 = new Order();
                                order1 = _context.Orders.Find(order.OrderId);
                                order1.TotalAmount = order.DeliveryFee + totalAmount;
                                _context.Entry(order1).State = EntityState.Modified;
                                await _context.SaveChangesAsync();
                            }
                            else
                            {
                                if (exStId.InStockQuantity + exStId2.InStockQuantity >= item.UnitQuantity)
                                {
                                    var inOut = (from st in _context.Stocks
                                                 where st.StockId == exStId.StockId
                                                 select new
                                                 {
                                                     st.InQuantity,
                                                     st.OutQuantity
                                                 }).FirstOrDefault();

                                    Stock stock = new Stock();
                                    stock = _context.Stocks.Find(exStId.StockId);
                                    stock.OutQuantity = inOut.OutQuantity + exStId.InStockQuantity;
                                    _context.Entry(stock).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();

                                    Stock stock1 = new Stock();
                                    stock1 = _context.Stocks.Find(exStId.StockId);
                                    stock1.InStockQuantity = inOut.InQuantity - stock.OutQuantity;
                                    _context.Entry(stock1).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();

                                    Stock stock2 = new Stock();
                                    stock2 = _context.Stocks.Find(exStId.StockId);
                                    stock2.StockPrice = stock.PurchasePrice * stock1.InStockQuantity;
                                    _context.Entry(stock2).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();

                                    var inStQty = (from q in _context.Stocks
                                                   where q.StockId == exStId.StockId
                                                   select q.InStockQuantity).FirstOrDefault();

                                    var pid = (from p in _context.Products
                                               where p.ProductCode == pCode
                                               select p.ProductId).FirstOrDefault();

                                    if (inStQty <= 5)
                                    {
                                        Product prd = new Product();
                                        prd = _context.Products.Find(pid);
                                        prd.Status = Enums.ProductStatus.NotAvailable;
                                        _context.Entry(prd).State = EntityState.Modified;
                                        await _context.SaveChangesAsync();
                                    }






                                    var inOut2 = (from st in _context.Stocks
                                                  where st.StockId == exStId2.StockId
                                                  select new
                                                  {
                                                      st.InQuantity,
                                                      st.OutQuantity
                                                  }).FirstOrDefault();

                                    Stock stocks = new Stock();
                                    stocks = _context.Stocks.Find(exStId2.StockId);
                                    stocks.OutQuantity = inOut2.OutQuantity + item.UnitQuantity - exStId.InStockQuantity;
                                    _context.Entry(stocks).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();

                                    Stock stocks1 = new Stock();
                                    stocks1 = _context.Stocks.Find(exStId2.StockId);
                                    stocks1.InStockQuantity = inOut2.InQuantity - stocks.OutQuantity;
                                    _context.Entry(stocks1).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();

                                    Stock stocks2 = new Stock();
                                    stocks2 = _context.Stocks.Find(exStId2.StockId);
                                    stocks2.StockPrice = stocks.PurchasePrice * stocks1.InStockQuantity;
                                    _context.Entry(stock2).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();

                                    var inStQty2 = (from q in _context.Stocks
                                                    where q.StockId == exStId2.StockId
                                                    select q.InStockQuantity).FirstOrDefault();


                                    if (inStQty2 <= 5)
                                    {
                                        Product prd = new Product();
                                        prd = _context.Products.Find(pid);
                                        prd.Status = Enums.ProductStatus.NotAvailable;
                                        _context.Entry(prd).State = EntityState.Modified;
                                        await _context.SaveChangesAsync();
                                    }

                                    totalQty += item.UnitQuantity;
                                    totalAmount += salesDetail.NetAmount;

                                    SalesMaster salesMaster2 = new SalesMaster();
                                    salesMaster2 = _context.SalesMasters.Find(sMaster.SalesMasterId);
                                    salesMaster2.TotalAmount = totalAmount;
                                    salesMaster2.TotalQuantity = totalQty;
                                    _context.Entry(salesMaster2).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();

                                    Order order2 = new Order();
                                    order2 = _context.Orders.Find(order.OrderId);
                                    order2.TotalAmount = order.DeliveryFee + totalAmount;
                                    _context.Entry(order2).State = EntityState.Modified;
                                    await _context.SaveChangesAsync();
                                }
                                else
                                {
                                    return BadRequest("Out of Stock");
                                }

                            }
                        }
                    }
                    transaction.Commit();
                    return Ok("Order completed for customer: " + userId);

                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    ModelState.AddModelError("", ex.Message);
                    return BadRequest(ModelState);
                }
            }
            //return BadRequest();
        }
    }
}
