using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.Context;
using eCommerce.EmailSending;
using eCommerce.Enums;
using eCommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly databaseContext _context;


        public HomeController(databaseContext context)
        {
            _context = context;
        }

        // Get all the products
        [HttpGet("products")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        //Get products by id
        [HttpGet("products/{id}")]
        public async Task<ActionResult<Product>> GetProductsById(int id)
        {
            var prd = _context.Products.Where(p => p.ProductId == id).FirstOrDefaultAsync();
            return await prd;
        }

        // Get category by parent id
        [HttpGet("getcategory/{id}")]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategoriesByParent(int id)
        {
            var childCategory = _context.Categories.Where(c => c.ParentId == id).ToListAsync();
            return await childCategory;
        }

        // Track order by orderNo
        [HttpGet("trackorder")]
        public ActionResult<string> TrackOrder(string orderNo)
        {
            var orderStatus = (from o in _context.Orders
                               where o.OrderNo == orderNo
                               select o.OrderStatus).FirstOrDefault();
            var deliveryDate = (from o in _context.Orders
                               where o.OrderNo == orderNo
                               select o.DeliveryDate).FirstOrDefault();
            if (orderStatus == OrderStatus.Ordered)
            {
                return orderNo + " is " + OrderStatus.Ordered + "\nDelivery Date is " + deliveryDate;
            }
            else if(orderStatus == OrderStatus.Delivered)
            {
                return orderNo + " is " + OrderStatus.Delivered;
            }
            else if (orderStatus == OrderStatus.Cancelled)
            {
                return orderNo + " has been " + OrderStatus.Cancelled;
            }
            else
            {
                return orderStatus.ToString();
            }
        }

        
        // Get top sold products
        [HttpGet("hotdeals")]
        public async Task<ActionResult<IEnumerable<Product>>> GetHotDeals()
        {
            var hotDeals = (
                from p in _context.Products
                join s in _context.SalesDetails
                on p.ProductId equals s.ProductId
                group new { s, p } by new
                {
                    s.UnitQuantity,
                    p.ProductId,
                    p.Name,
                    p.ProductCode,
                    p.CategoryId,
                    p.DiscountRate,
                    p.SalesPrice,
                    p.UnitId,
                    p.ProductDescription,
                } into table1
                orderby table1.Key.UnitQuantity descending
                select new Product
                {
                    ProductId = table1.Key.ProductId,
                    Name = table1.Key.Name,
                    ProductCode = table1.Key.ProductCode,
                    CategoryId = table1.Key.CategoryId,
                    DiscountRate = table1.Key.DiscountRate,
                    SalesPrice = table1.Key.SalesPrice,
                    UnitId = table1.Key.UnitId,
                    ProductDescription = table1.Key.ProductDescription,
                })
                .Distinct()
                .Take(10)
                .ToListAsync();
            return await hotDeals;
        }
    }
}