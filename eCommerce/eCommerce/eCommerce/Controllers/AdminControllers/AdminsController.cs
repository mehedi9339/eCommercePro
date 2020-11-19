using eCommerce.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using eCommerce.Enums;
using System;
using static eCommerce.ViewModels.dbViewModels;
using eCommerce.Models;

namespace eCommerce.Controllers.AdminControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : Controller
    {
        private readonly databaseContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public AdminsController(databaseContext context, UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet("PurchaseHistory")]
        public async Task<ActionResult<IEnumerable<PurchaseHistory>>> PurchaseHistory()
        {
            var purchaseHistory = await (from p in _context.Products
                                         join s in _context.PurchaseDetails
                                         on p.ProductId equals s.ProductId
                                         join u in _context.Units
                                         on p.UnitId equals u.UnitId
                                         join c in _context.Categories
                                         on p.CategoryId equals c.CategoryId
                                         select new PurchaseHistory
                                         {
                                             CategoryName = c.Name,
                                             ProductName = p.Name,
                                             ProductCode = p.ProductCode,
                                             ProductDescription = p.ProductDescription,
                                             UnitName = u.Name,
                                             TotalPrice = s.TotalPrice,
                                             PurchaseDate = s.EntryDate,
                                         }).ToListAsync();
            return purchaseHistory;
        }

        [HttpGet("OrderHistory")]
        public async Task<ActionResult<IEnumerable<OrderHistory>>> OrderHistory()
        {
            var orderHistory = await (from c in _context.Customer
                                      join o in _context.Orders
                                      on c.CustomerId equals o.CustomerId
                                      join s in _context.ShippingAddresses
                                      on o.ShippingAddressId equals s.ShippingAddressId
                                      join sa in _context.SalesMasters
                                      on o.OrderId equals sa.OrderId
                                      select new OrderHistory
                                      {
                                          OrderNo = o.OrderNo,
                                          CustomerName = c.Name,
                                          CustomerNo = c.ContactNo,
                                          ShippingAddress = s.Address,
                                          TotalQuantity = sa.TotalQuantity,
                                          TotalAmount = o.TotalAmount,
                                          BillNo = sa.BillNo,
                                          OrderDate = o.OrderDate,
                                          ShippingDate = o.ShippingDate,
                                          DeliveryDate = o.DeliveryDate,
                                          PaymentStatus = (o.PaymentStatus == true) ? "Paid" : "Unpaid",
                                          OrderStatus = o.OrderStatus
                                      }).ToListAsync();
            return orderHistory;
        }

        [HttpGet("OrdersByStatus")]
        public async Task<ActionResult<IEnumerable<OrderHistory>>> OrdersByStatus(OrderStatus orderStatus)
        {
            var orderHistory = await (from c in _context.Customer
                                      join o in _context.Orders
                                      on c.CustomerId equals o.CustomerId
                                      join s in _context.ShippingAddresses
                                      on o.ShippingAddressId equals s.ShippingAddressId
                                      join sa in _context.SalesMasters
                                      on o.OrderId equals sa.OrderId
                                      where o.OrderStatus == orderStatus
                                      select new OrderHistory
                                      {
                                          OrderNo = o.OrderNo,
                                          CustomerName = c.Name,
                                          CustomerNo = c.ContactNo,
                                          ShippingAddress = s.Address,
                                          TotalQuantity = sa.TotalQuantity,
                                          BillNo = sa.BillNo,
                                          OrderDate = o.OrderDate,
                                          DeliveryDate = o.DeliveryDate,
                                          ShippingDate = o.ShippingDate,
                                          PaymentStatus = (o.PaymentStatus == true) ? "Paid" : "Unpaid",
                                          TotalAmount = o.TotalAmount,
                                          OrderStatus = o.OrderStatus
                                      }).ToListAsync();
            return orderHistory;
        }

        [HttpGet("OrdersByCustomer")]
        public async Task<ActionResult<IEnumerable<OrderHistory>>> OrdersByStatus(string customerEmail)
        {
            var orderHistory = await (from c in _context.Customer
                                      join o in _context.Orders
                                      on c.CustomerId equals o.CustomerId
                                      join s in _context.ShippingAddresses
                                      on o.ShippingAddressId equals s.ShippingAddressId
                                      join sa in _context.SalesMasters
                                      on o.OrderId equals sa.OrderId
                                      where c.Email == customerEmail
                                      select new OrderHistory
                                      {
                                          OrderNo = o.OrderNo,
                                          CustomerName = c.Name,
                                          CustomerNo = c.ContactNo,
                                          ShippingAddress = s.Address,
                                          TotalQuantity = sa.TotalQuantity,
                                          BillNo = sa.BillNo,
                                          OrderDate = o.OrderDate,
                                          DeliveryDate = o.DeliveryDate,
                                          ShippingDate = o.ShippingDate,
                                          PaymentStatus = (o.PaymentStatus == true) ? "Paid" : "Unpaid",
                                          TotalAmount = o.TotalAmount,
                                          OrderStatus = o.OrderStatus
                                      }).ToListAsync();
            return orderHistory;
        }

        [HttpGet("OrdersByDateRange")]
        public async Task<ActionResult<IEnumerable<OrderHistory>>> OrdersByStatus(DateTime startDate, DateTime endDate)
        {
            var orderHistory = await (from c in _context.Customer
                                      join o in _context.Orders
                                      on c.CustomerId equals o.CustomerId
                                      join s in _context.ShippingAddresses
                                      on o.ShippingAddressId equals s.ShippingAddressId
                                      join sa in _context.SalesMasters
                                      on o.OrderId equals sa.OrderId
                                      select new OrderHistory
                                      {
                                          OrderNo = o.OrderNo,
                                          CustomerName = c.Name,
                                          CustomerNo = c.ContactNo,
                                          ShippingAddress = s.Address,
                                          TotalQuantity = sa.TotalQuantity,
                                          BillNo = sa.BillNo,
                                          OrderDate = o.OrderDate,
                                          DeliveryDate = o.DeliveryDate,
                                          ShippingDate = o.ShippingDate,
                                          PaymentStatus = (o.PaymentStatus == true) ? "Paid" : "Unpaid",
                                          TotalAmount = o.TotalAmount,
                                          OrderStatus = o.OrderStatus
                                      }).Where(w => w.OrderDate >= startDate && w.OrderDate <= endDate).ToListAsync();
            return orderHistory;
        }

        [HttpGet("StockHistory")]
        public async Task<ActionResult<IEnumerable<StockHistory>>> StockHistory()
        {
            var stockHistory = await (
                from p in _context.Products
                join s in _context.Stocks
                on p.ProductCode equals s.ProductCode
                join c in _context.Colors
                on s.ColorId equals c.Id
                join z in _context.Sizes
                on s.SizeId equals z.Id
                join m in _context.ModelTbls
                on s.ModelId equals m.Id
                select new StockHistory
                {
                    ProductCode = p.ProductCode,
                    ProductName = p.Name,
                    Color = c.Name,
                    Size = z.Name,
                    Model = m.Name,
                    InStockQuantity = s.InStockQuantity,
                    StockDate = s.StockDate,
                    InQuantity = s.InQuantity,
                    OutQuantity = s.OutQuantity,
                    ExpireDate = s.ExpiryDate
                }).ToListAsync();
            return stockHistory;
        }

        [HttpGet("ExpiredProducts")]
        public async Task<ActionResult<IEnumerable<StockHistory>>> ExpiredProducts()
        {
            var expiredProducts = await (
                from p in _context.Products
                join s in _context.Stocks
                on p.ProductCode equals s.ProductCode
                join c in _context.Colors
                on s.ColorId equals c.Id
                join z in _context.Sizes
                on s.SizeId equals z.Id
                join m in _context.ModelTbls
                on s.ModelId equals m.Id
                where s.ExpiryDate <= DateTime.Now
                select new StockHistory
                {
                    ProductCode = p.ProductCode,
                    ProductName = p.Name,
                    Color = c.Name,
                    Size = z.Name,
                    Model = m.Name,
                    InStockQuantity = s.InStockQuantity,
                    StockDate = s.StockDate,
                    InQuantity = s.InQuantity,
                    OutQuantity = s.OutQuantity,
                    ExpireDate = s.ExpiryDate
                }).ToListAsync();
            return expiredProducts;
        }

        [HttpGet("WishList")]
        public async Task<ActionResult<IEnumerable<WishListVm>>> GetWisthLists()
        {
            var wishList = await (from w in _context.WisthLists
                                  join c in _context.Customer
                                  on w.CustomerId equals c.CustomerId
                                  join p in _context.Products
                                  on w.ProductId equals p.ProductId
                                  select new WishListVm
                                  {
                                      CustomerName = c.Name,
                                      CustomerEmail = c.Email,
                                      CustomerContact = c.ContactNo,
                                      ProductCode = p.ProductCode,
                                      Quantity = w.Quantity
                                  }).ToListAsync();
            return wishList;
        }
        [HttpGet("SalesHistory")]
        public async Task<ActionResult<IEnumerable<SalesHistory>>> SalesHistory()
        {
            var sHistory = await (from p in _context.Products
                                  join sd in _context.SalesDetails
                                  on p.ProductId equals sd.ProductId
                                  join sm in _context.SalesMasters
                                  on sd.SalesMasterId equals sm.SalesMasterId
                                  join t in _context.Categories
                                  on p.CategoryId equals t.CategoryId
                                  join c in _context.Colors
                                  on sd.ColorId equals c.Id
                                  join z in _context.Sizes
                                  on sd.SizeId equals z.Id
                                  join m in _context.ModelTbls
                                  on sd.ModelId equals m.Id
                                  join o in _context.Orders
                                  on sm.OrderId equals o.OrderId
                                  select new SalesHistory
                                  {
                                      ProductName = p.Name,
                                      ProductCode = p.ProductCode,
                                      ProductDescription = p.ProductDescription,
                                      Color = c.Name,
                                      Size = z.Name,
                                      Model = m.Name,
                                      SalesDate = sm.SalesDate,
                                      SalesDiscount = sd.DiscountRate,
                                      TotalQuantity = sm.TotalQuantity,
                                      TotalAmount = sm.TotalAmount,
                                      OrderNo = o.OrderNo
                                  }).ToListAsync();
            return sHistory;
        }

        [HttpGet("SalesHistoryByDate")]
        public async Task<ActionResult<IEnumerable<SalesHistory>>> SalesHistoryByDate(DateTime startDate, DateTime endDate)
        {
            var sHistory = await (from p in _context.Products
                                  join sd in _context.SalesDetails
                                  on p.ProductId equals sd.ProductId
                                  join sm in _context.SalesMasters
                                  on sd.SalesMasterId equals sm.SalesMasterId
                                  join t in _context.Categories
                                  on p.CategoryId equals t.CategoryId
                                  join c in _context.Colors
                                  on sd.ColorId equals c.Id
                                  join z in _context.Sizes
                                  on sd.SizeId equals z.Id
                                  join m in _context.ModelTbls
                                  on sd.ModelId equals m.Id
                                  join o in _context.Orders
                                  on sm.OrderId equals o.OrderId
                                  select new SalesHistory
                                  {
                                      ProductName = p.Name,
                                      ProductCode = p.ProductCode,
                                      ProductDescription = p.ProductDescription,
                                      Color = c.Name,
                                      Size = z.Name,
                                      Model = m.Name,
                                      SalesDate = sm.SalesDate,
                                      SalesDiscount = sd.DiscountRate,
                                      TotalQuantity = sm.TotalQuantity,
                                      TotalAmount = sm.TotalAmount,
                                      OrderNo = o.OrderNo
                                  }).Where(w => w.SalesDate >= startDate && w.SalesDate <= endDate).ToListAsync();
            return sHistory;
        }

        [HttpGet("SalesShortSummary")]
        public async Task<ActionResult<IEnumerable<SalesShortSummary>>> SalesShortSummary()
        {
            var salesSummary = await (from p in _context.Products
                                      join sd in _context.SalesDetails
                                      on p.ProductId equals sd.ProductId
                                      join sm in _context.SalesMasters
                                      on sd.SalesMasterId equals sm.SalesMasterId
                                      join c in _context.Categories
                                      on p.CategoryId equals c.CategoryId
                                      join un in _context.Units
                                      on p.UnitId equals un.UnitId
                                      select new SalesShortSummary
                                      {
                                          ProductName = p.Name,
                                          ProductDescription = p.ProductDescription,
                                          CategoryName = c.Name,
                                          UnitName = un.Name,
                                          UnitQty = sd.UnitQuantity,
                                          UnitPrice = sd.UintPrice,
                                          SalesDate = sm.SalesDate,
                                          TotalQty = sm.TotalQuantity,
                                          TotalPrice = sm.TotalAmount
                                      }).ToListAsync();
            return salesSummary;
        }

        [HttpPost]
        public async Task<ActionResult<Order>> UpdateOrder(string orderNo, OrderStatus orderStatus)
        {
            var orderId = await (from o in _context.Orders
                                 where o.OrderNo == orderNo
                                 select o.OrderId).FirstOrDefaultAsync();
            Order order = new Order();
            order = _context.Orders.Find(orderId);
            order.OrderStatus = orderStatus;
            _context.Entry(order).State = EntityState.Modified;
            if (await _context.SaveChangesAsync() > 0)
            {
                return Ok("Changed to " + orderStatus);
            }
            return BadRequest();
        }

    }
}