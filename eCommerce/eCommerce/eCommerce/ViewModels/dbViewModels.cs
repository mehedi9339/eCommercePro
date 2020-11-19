using eCommerce.Enums;
using eCommerce.Models;
using System;

namespace eCommerce.ViewModels
{
    public class dbViewModels
    {
        public class JwtSettings
        {
            public string Issuer { get; set; }
            public string Secret { get; set; }
            public int ExpirationInDays { get; set; }
        }
        public class OrderHistory
        {
            public string OrderNo { get; set; }
            public string CustomerName { get; set; }
            public string CustomerNo { get; set; }
            public string ShippingAddress { get; set; }
            public int TotalQuantity { get; set; }
            public decimal TotalAmount { get; set; }
            public string BillNo { get; set; }
            public DateTime OrderDate { get; set; }
            public DateTime ShippingDate { get; set; }
            public DateTime DeliveryDate { get; set; }
            public string PaymentStatus { get; set; }
            public OrderStatus OrderStatus { get; set; }
        }
        public class OrderVm
        {
            public Order Order { get; set; }
            public SalesMaster SalesMaster { get; set; }
        }
        public class ProductVm
        {
            public int ProductId { get; set; }
            public int CategoryId { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public ProductStatus Status { get; set; }
            public decimal DiscountRate { get; set; }
            public decimal SalesPrice { get; set; }
            public string Image1 { get; set; }
            public string Image2 { get; set; }
            public string Image3 { get; set; }
        }
        public class PurchaseHistory
        {
            public string CategoryName { get; set; }
            public string ProductName { get; set; }
            public string ProductCode { get; set; }
            public string ProductDescription { get; set; }
            public string UnitName { get; set; }
            public decimal TotalPrice { get; set; }
            public DateTime PurchaseDate { get; set; }
        }
        public class PurchaseVm
        {
            public PurchaseMaster PurchaseMaster { get; set; }
            public PurchaseDetail PurchaseDetail { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public string Size { get; set; }
        }
        public class SalesHistory
        {
            public string ProductName { get; set; }
            public string ProductCode { get; set; }
            public string ProductDescription { get; set; }
            public string Color { get; set; }
            public string Size { get; set; }
            public string Model { get; set; }
            public DateTime SalesDate { get; set; }
            public decimal SalesDiscount { get; set; }
            public int TotalQuantity { get; set; }
            public decimal TotalAmount { get; set; }
            public string OrderNo { get; set; }
        }
        public class SalesShortSummary
        {
            public string ProductName { get; set; }
            public string ProductDescription { get; set; }
            public string CategoryName { get; set; }
            public string UnitName { get; set; }
            public int UnitQty { get; set; }
            public decimal UnitPrice { get; set; }
            public DateTime SalesDate { get; set; }
            public int TotalQty { get; set; }
            public decimal TotalPrice { get; set; }
        }
        public class StockHistory
        {
            public string ProductCode { get; set; }
            public string ProductName { get; set; }
            public string Color { get; set; }
            public string Size { get; set; }
            public string Model { get; set; }
            public int InStockQuantity { get; set; }
            public DateTime StockDate { get; set; }
            public int InQuantity { get; set; }
            public int OutQuantity { get; set; }
            public DateTime ExpireDate { get; set; }
        }
        public class UserVm
        {
            public string UserName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }
        public class WishListVm
        {
            public string CustomerName { get; set; }
            public string CustomerEmail { get; set; }
            public string CustomerContact { get; set; }
            public string ProductCode { get; set; }
            public int Quantity { get; set; }
        }
    }
}
