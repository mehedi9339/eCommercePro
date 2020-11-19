using eCommerce.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models
{
    public class Role : IdentityRole<Guid>
    {

    }
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Photo { get; set; }

        //Navigations
        public List<Customer> Customers { get; set; }
        public List<PurchaseDetail> PurchaseDetails { get; set; }
    }
    public class UserRoles : IdentityUserRole<Guid>
    {
    }
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        [ForeignKey("Customer"), Required]
        public int CustomerId { get; set; }

        //Navigations
        public Customer Customer { get; set; }
        public List<CartDetail> CartDetails { get; set; }
    }
    public class CartDetail
    {
        [Key]
        public int CartDetailId { get; set; }
        [ForeignKey("Cart")]
        public int CartId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }

        //Navigations
        public Cart Cart { get; set; }
        public Product Product { get; set; }
    }
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string OrderNo { get; set; }
        [ForeignKey("ShippingAddress")]
        public int ShippingAddressId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [DefaultValue(0)]
        public OrderStatus OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime ShippingDate { get; set; }
        public decimal DeliveryFee { get; set; }
        public bool PaymentStatus { get; set; }
        public string TransactionId { get; set; }
        public DateTime TransactionTime { get; set; }
        public decimal TotalAmount { get; set; }

        //Navigations
        public ShippingAddress ShippingAddress { get; set; }
        public Customer Customer { get; set; }
        public List<SalesMaster> salesMasters { get; set; }
    }
    public class Color
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigations
        public List<PurchaseDetail> PurchaseDetails { get; set; }
        public List<Stock> Stocks { get; set; }
        public List<SalesDetail> SalesDetails { get; set; }
    }
    public class Currier
    {
        [Key]
        public int CurrierId { get; set; }
        [Required, MaxLength(200, ErrorMessage = "Name cannot exceed 200 characters")]
        public string Name { get; set; }
        [ForeignKey("District"), Required]
        public int DistrictId { get; set; }
        [ForeignKey("ThanaId"), Required]
        public int ThanaId { get; set; }
        [Required, MaxLength(11, ErrorMessage = "Phone number cannot exceed 11 digits")]
        public string Phone { get; set; }

        //Navigations
        public District District { get; set; }
        public Thana Thana { get; set; }
        public List<ShippingAddress> ShippingAddresses { get; set; }
    }
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [MaxLength(11)]
        public string ContactNo { get; set; }
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public string CompanyName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string CompanyContact { get; set; }
        public string CompanyWebsite { get; set; }
        [ForeignKey("District")]
        public int DistrictId { get; set; }
        [ForeignKey("Thana")]
        public int ThanaId { get; set; }

        //Navigations
        public User User { get; set; }
        public Thana Thana { get; set; }
        public District District { get; set; }
        public List<ShippingAddress> ShippingAddresses { get; set; }
        public List<WishList> WisthLists { get; set; }
        public List<Order> Orders { get; set; }
        public List<Cart> Carts { get; set; }
    }
    public class District : IValidatableObject
    {
        [Key]
        public int DistrictId { get; set; }
        [Required]
        public string Name { get; set; }

        //Navigations
        public List<Thana> Thanas { get; set; }
        public List<Customer> Customers { get; set; }
        public List<ShippingAddress> shippingAddresses { get; set; }
        public List<Currier> Curriers { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();
            if (Name == null || Name == string.Empty)
            {
                errors.Add(new ValidationResult(
                "Name is required"));
            }
            return errors;
        }
    }
    public class ModelTbl
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigations
        public List<PurchaseDetail> PurchaseDetails { get; set; }
        public List<Stock> Stocks { get; set; }
        public List<SalesDetail> SalesDetails { get; set; }
    }
    public class ProductType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class ShippingAddress
    {
        [Key]
        public int ShippingAddressId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, MaxLength(11, ErrorMessage = "Phone cannot exceed 11 characters")]
        public string Phone { get; set; }
        [ForeignKey("District")]
        public int DistrictId { get; set; }
        [ForeignKey("Thana")]
        public int ThanaId { get; set; }
        public string Address { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [ForeignKey("Currier"), Required]
        public int CurrierId { get; set; }


        //Navigations
        public Customer Customer { get; set; }
        public Thana Thana { get; set; }
        public District District { get; set; }
        public Currier Currier { get; set; }
        public List<Order> Orders { get; set; }
    }
    public class Size
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigations
        public List<PurchaseDetail> PurchaseDetails { get; set; }
        public List<Stock> Stocks { get; set; }
        public List<SalesDetail> SalesDetails { get; set; }
    }
    //public class StockDetails
    //{
    //    [Key]
    //    public int StockDetailsId { get; set; }
    //    [ForeignKey("Stock")]
    //    public int StockId { get; set; }
    //    public DateTime StockDate { get; set; }
    //    [DefaultValue(0)]
    //    public int InQuantity { get; set; }
    //    [DefaultValue(0)]
    //    public int OutQuantity { get; set; }
    //    public decimal StockPrice { get; set; }
    //    public int BalancedQuantity { get; set; }

    //    //Navigations
    //    public Stocks Stock { get; set; }
    //}
    //public class Stocks
    //{
    //    [Key]
    //    public int StockId { get; set; }
    //    [Required]
    //    public string ProductCode { get; set; }
    //    [DefaultValue(0)]
    //    public int InStockQuantity { get; set; }
    //    public int LotNo { get; set; }

    //    //Navigations
    //    public List<StockDetails> StockDetails { get; set; }
    //}
    public class Thana
    {
        [Key]
        public int ThanaId { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("District")]
        public int DistrictId { get; set; }

        //Navigations
        public District District { get; set; }
        public List<Customer> Customers { get; set; }
        public List<ShippingAddress> shippingAddresses { get; set; }
        public List<Currier> Curriers { get; set; }
    }
    public class Unit
    {
        [Key]
        public int UnitId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ShortName { get; set; }

        //Navigations
        public List<Product> Products { get; set; }
    }
    public class WishList
    {
        [Key]
        public int WishListId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        //Navigations
        public Customer Customer { get; set; }
        public Product Product { get; set; }

    }
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required, DefaultValue(0)]
        public int ParentId { get; set; }

        //Navigations
        public List<Product> Products { get; set; }
    }
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public ProductStatus Status { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("Unit")]
        public int? UnitId { get; set; }
        public string ProductCode { get; set; }
        public ProductType ProductType { get; set; }
        public decimal PreviousPrice { get; set; }
        [DefaultValue(0)]
        public decimal DiscountRate { get; set; }
        public decimal SalesPrice { get; set; }
        public string ProductDescription { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }

        //Navigations
        public Category Category { get; set; }
        public Unit Unit { get; set; }
        public List<CartDetail> CartDetails { get; set; }
        public List<PurchaseDetail> PurchaseDetails { get; set; }
        public List<SalesDetail> SalesDetails { get; set; }

        public List<WishList> WisthLists { get; set; }
    }
    public class PurchaseDetail
    {
        [Key]
        public int PurchaseDetailId { get; set; }
        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [Required]
        public string ProductCode { get; set; }
        [ForeignKey("ModelTbl")]
        public int? ModelId { get; set; }
        [ForeignKey("Color")]
        public int? ColorId { get; set; }
        [ForeignKey("Size")]
        public int? SizeId { get; set; }
        [ForeignKey("User")]
        public Guid EntryBy { get; set; }
        public DateTime EntryDate { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal VatRate { get; set; }
        public decimal NetAmount { get; set; }
        public int UnitQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal SalesPrice { get; set; }
        public string Description { get; set; }
        public DateTime ExpiryDate { get; set; }

        [ForeignKey("PurchaseMaster")]
        public int MasterId { get; set; }

        //Navigations
        public PurchaseMaster PurchaseMaster { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }
        public ModelTbl ModelTbl { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
    }
    public class PurchaseMaster
    {
        public PurchaseMaster()
        {
            PurchaseDetails = new HashSet<PurchaseDetail>();
        }
        [Key]
        public int PurchaseMasterId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal VatRate { get; set; }
        public decimal LaborCost { get; set; }
        public string VoucharNo { get; set; }
        public string BillNo { get; set; }
        public string Note { get; set; }
        public decimal NetAmount { get; set; }

        //Navigations
        public IEnumerable<PurchaseDetail> PurchaseDetails { get; set; }
    }
    public class SalesDetail
    {
        [Key]
        public int SalesDetailId { get; set; }
        [ForeignKey("SalesMaster")]
        public int SalesMasterId { get; set; }
        public decimal UintPrice { get; set; }
        public int UnitQuantity { get; set; }
        [ForeignKey("ModelTbl")]
        public int? ModelId { get; set; }
        [ForeignKey("Color")]
        public int? ColorId { get; set; }
        [ForeignKey("Size")]
        public int? SizeId { get; set; }
        public decimal VatRate { get; set; }
        public decimal VatAmount { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal NetAmount { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        //Navigations
        public SalesMaster SalesMaster { get; set; }
        public Product Product { get; set; }
        public ModelTbl ModelTbl { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
    }
    public class SalesMaster
    {
        public SalesMaster()
        {
            SalesDetails = new HashSet<SalesDetail>();
        }
        [Key]
        public int SalesMasterId { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public DateTime SalesDate { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string VoucherNo { get; set; }
        public string BillNo { get; set; }
        public decimal TotalAmount { get; set; }
        [StringLength(500)]
        public string Note { get; set; }

        //Navigations
        public Order Order { get; set; }
        public virtual IEnumerable<SalesDetail> SalesDetails { get; set; }

    }
    public class Stock
    {
        [Key]
        public int StockId { get; set; }
        public DateTime StockDate { get; set; }
        [Required]
        public string ProductCode { get; set; }
        [ForeignKey("ModelTbl")]
        public int? ModelId { get; set; }
        [ForeignKey("Color")]
        public int? ColorId { get; set; }
        [ForeignKey("Size")]
        public int? SizeId { get; set; }
        [DefaultValue(0)]
        public int InQuantity { get; set; }
        [DefaultValue(0)]
        public int OutQuantity { get; set; }
        [DefaultValue(0)]
        public int InStockQuantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal StockPrice { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int LotNo { get; set; }

        //Navigations
        public ModelTbl ModelTbl { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
    }
}
