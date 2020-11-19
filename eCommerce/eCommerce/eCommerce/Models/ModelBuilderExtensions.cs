using eCommerce.Enums;
using Microsoft.AspNet.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace eCommerce.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var arId = Guid.NewGuid();
            var suId = Guid.NewGuid();
            var usId = Guid.NewGuid();
            var usrId = Guid.NewGuid();

            //Add Roles
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = arId,
                    Name = "Super Admin",
                    NormalizedName = "SUPER ADMIN"
                },
                new Role
                {
                    Id = Guid.NewGuid(),
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new Role
                {
                    Id = usrId,
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                }
            );
            var PasswordHash = new PasswordHasher();
            // Add items in Users
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = suId,
                    Email = "sadmin@sadmin.com",
                    NormalizedEmail = "sadmin@sadmin.com".ToUpper(),
                    PasswordHash = PasswordHash.HashPassword("Test@1234")
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Email = "admin@admin.com",
                    NormalizedEmail = "admin@admin.com".ToUpper(),
                    PasswordHash = PasswordHash.HashPassword("Test@1234")
                },
                new User
                {
                    Id = usId,
                    Email = "user@user.com",
                    NormalizedEmail = "user@user.com".ToUpper(),
                    PasswordHash = PasswordHash.HashPassword("Test@1234")
                }
            );

            // Add items in UserRoles
            modelBuilder.Entity<UserRoles>().HasData(
                new UserRoles
                {
                    UserId = suId,
                    RoleId = arId
                },
                new UserRoles
                {
                    UserId = usId,
                    RoleId = usrId
                }
            );

            // Add Units
            modelBuilder.Entity<Unit>().HasData(
                new Unit
                {
                    UnitId = 1,
                    Name = "Killogram",
                    ShortName = "Kg"
                },
                new Unit
                {
                    UnitId = 2,
                    Name = "Gram",
                    ShortName = "g"
                },
                new Unit
                {
                    UnitId = 3,
                    Name = "Litter",
                    ShortName = "L"
                }
            );

            // Add Model
            modelBuilder.Entity<ModelTbl>().HasData(
                new ModelTbl
                {
                    Id = 1,
                    Name = "No Model"
                },
                new ModelTbl
                {
                    Id = 2,
                    Name = "skghsdjg"
                }
            );

            // Add Color
            modelBuilder.Entity<Color>().HasData(
                new Color
                {
                    Id = 1,
                    Name = "No Color"
                },
                new Color
                {
                    Id = 2,
                    Name = "bbbbdfad"
                }
            );

            // Add Size
            modelBuilder.Entity<Size>().HasData(
                new Size
                {
                    Id = 1,
                    Name = "No Size"
                },
                new Size
                {
                    Id = 2,
                    Name = "klasdfasd"
                }
            );

            // Add District
            modelBuilder.Entity<District>().HasData(
                new District
                {
                    DistrictId = 1,
                    Name = "Dhaka"
                },
                new District
                {
                    DistrictId = 2,
                    Name = "Kustia"
                },
                new District
                {
                    DistrictId = 3,
                    Name = "Pabna"
                }
            );

            // Add Thana
            modelBuilder.Entity<Thana>().HasData(
                new Thana
                {
                    ThanaId = 1,
                    Name = "Mirpur",
                    DistrictId = 1
                },
                new Thana
                {
                    ThanaId = 2,
                    Name = "Khoksa",
                    DistrictId = 2
                },
                new Thana
                {
                    ThanaId = 3,
                    Name = "Pabna Sadar",
                    DistrictId = 3
                }
            );

            // Add Currier
            modelBuilder.Entity<Currier>().HasData(
                new Currier
                {
                    CurrierId = 1,
                    Name = "Sundarban",
                    DistrictId = 1,
                    ThanaId = 1,
                    Phone = "01927343454"
                },
                new Currier
                {
                    CurrierId = 2,
                    Name = "Continental",
                    DistrictId = 1,
                    ThanaId = 1,
                    Phone = "01927356754"
                }
            );

            // Add Category
            modelBuilder.Entity<Category>().HasData(
               new Category
               {
                   CategoryId = 1,
                   Name = "Electronics",
                   Description = "Electronics",
                   ParentId = 0
               },
               new Category
               {
                   CategoryId = 2,
                   Name = "Animal Food",
                   Description = "Cat",
                   ParentId = 0
               },
                new Category
                {
                    CategoryId = 3,
                    Name = "Light",
                    Description = "Light",
                    ParentId = 1
                },
                new Category
                {
                    CategoryId = 4,
                    Name = "Energy Bulb",
                    Description = "Energy Bulb",
                    ParentId = 3
                }
           );

            // Add Customer
            modelBuilder.Entity<Customer>().HasData(
               new Customer
               {
                   CustomerId = 1,
                   Name = "Maham",
                   Address = "Dhaka",
                   ContactNo = "01678907623",
                   UserId = usId,
                   CompanyName = "Sr.Company",
                   Email = "m@m.com",
                   CompanyContact = "09876543",
                   CompanyWebsite = "sr@c.com",
                   DistrictId = 3,
                   ThanaId = 1
               }
           );

            //Add Order
            modelBuilder.Entity<Order>().HasData(
               new Order
               {
                   OrderId = 1,
                   OrderNo = "ORD202010031",
                   ShippingAddressId = 1,
                   CustomerId = 1,
                   OrderStatus = OrderStatus.Ordered,
                   OrderDate = DateTime.Now,
                   DeliveryStatus = DeliveryStatus.Pending,
                   DeliveryDate = DateTime.Now.AddDays(7),
                   ShippingDate = DateTime.Now.AddDays(1),
                   DeliveryFee = 50,
                   PaymentStatus = true,
                   TransactionId = "TRX1234567",
                   TransactionTime = DateTime.Now,
                   TotalAmount = 500
               }
           );

            //Add ShippingAddress
            modelBuilder.Entity<ShippingAddress>().HasData(
               new ShippingAddress
               {

                   ShippingAddressId = 1,
                   Name = "Mr ABC",
                   Phone = "01789876543",
                   DistrictId = 1,
                   ThanaId = 1,
                   Address = "Dhaka",
                   CustomerId = 1,
                   CurrierId = 1
               },
               new ShippingAddress
               {
                   ShippingAddressId = 2,
                   Name = "MR Doe",
                   Phone = "01978392903",
                   DistrictId = 2,
                   ThanaId = 2,
                   Address = "Khulna",
                   CustomerId = 1,
                   CurrierId = 1
               }
           );

            //Add Product
            modelBuilder.Entity<Product>().HasData(
               new Product
               {
                   ProductId = 1,
                   CategoryId = 1,
                   Status = ProductStatus.Available,
                   Name = "TV",
                   UnitId = 1,
                   ProductCode = "P01",
                   PreviousPrice = 600,
                   DiscountRate = 8,
                   SalesPrice = 500,
                   ProductDescription = "Electronics",
                   Image1 = "tv.img",
                   Image2 = "tv.img",
                   Image3 = "tv.img"
               },
               new Product
               {
                   ProductId = 2,
                   CategoryId = 2,
                   Status = ProductStatus.Available,
                   Name = "Shirt",
                   UnitId = 2,
                   ProductCode = "P02",
                   PreviousPrice = 600,
                   DiscountRate = 8,
                   SalesPrice = 600,
                   ProductDescription = "Cloths",
                   Image1 = "tv.img",
                   Image2 = "tv.img",
                   Image3 = "tv.img"
               },
                new Product
                {
                    ProductId = 3,
                    CategoryId = 2,
                    Status = ProductStatus.Available,
                    Name = "Sharee",
                    UnitId = 1,
                    ProductCode = "P03",
                    PreviousPrice = 600,
                    DiscountRate = 8,
                    SalesPrice = 2000,
                    ProductDescription = "Cloths",
                    Image1 = "tv.img",
                    Image2 = "tv.img",
                    Image3 = "tv.img"
                }
           );

            //Add SalesMaster
            modelBuilder.Entity<SalesMaster>().HasData(
               new SalesMaster
               {
                   SalesMasterId = 1,
                   OrderId = 1,
                   SalesDate = DateTime.Now,
                   TotalQuantity = 2,
                   TotalPrice = 1000,
                   VoucherNo = "abc",
                   BillNo = "123",
                   TotalAmount = 550,
                   Note = "success"
               }
           );

            //Add SalesDetail
            modelBuilder.Entity<SalesDetail>().HasData(
               new SalesDetail
               {
                   SalesDetailId = 1,
                   SalesMasterId = 1,
                   UintPrice = 676,
                   UnitQuantity = 89,
                   VatRate = 3,
                   VatAmount = 987,
                   DiscountRate = 5,
                   DiscountAmount = 50,
                   NetAmount = 550,
                   ProductId = 1
               },
               new SalesDetail
               {
                   SalesDetailId = 2,
                   SalesMasterId = 1,
                   UintPrice = 400,
                   UnitQuantity = 89,
                   VatRate = 3,
                   VatAmount = 987,
                   DiscountRate = 5,
                   DiscountAmount = 50,
                   NetAmount = 450,
                   ProductId = 1
               }
           );

            //Add PurchaseMaster
            modelBuilder.Entity<PurchaseMaster>().HasData(
               new PurchaseMaster
               {
                   PurchaseMasterId = 1,
                   PurchaseDate = new DateTime(2019, 12, 3),
                   TotalQuantity = 78,
                   TotalPrice = 40000,
                   DiscountRate = 5,
                   VatRate = 3,
                   LaborCost = 100,
                   VoucharNo = "avb",
                   BillNo = "123",
                   Note = "",
                   NetAmount = 565588
               }
           );

            //Add PurchaseDetail
            modelBuilder.Entity<PurchaseDetail>().HasData(
                new PurchaseDetail
                {
                    PurchaseDetailId = 1,
                    ProductId = 1,
                    ProductCode = "P01",
                    ModelId = 1,
                    ColorId = 1,
                    SizeId = 1,
                    EntryBy = usId,
                    EntryDate = DateTime.Now,
                    UnitPrice = 300,
                    DiscountRate = 5,
                    VatRate = 3,
                    NetAmount = 565,
                    UnitQuantity = 65,
                    TotalPrice = 4000,
                    Description = "dfas",
                    ExpiryDate = new DateTime(2021, 2, 2),
                    MasterId = 1
                },
               new PurchaseDetail
               {
                   PurchaseDetailId = 2,
                   ProductId = 2,
                   ProductCode = "P02",
                   ModelId = 2,
                   ColorId = 2,
                   SizeId = 1,
                   EntryBy = usId,
                   EntryDate = DateTime.Now,
                   UnitPrice = 300,
                   DiscountRate = 5,
                   VatRate = 3,
                   NetAmount = 565,
                   UnitQuantity = 65,
                   TotalPrice = 4000,
                   Description = "dfas",
                   ExpiryDate = new DateTime(2020, 2, 2),
                   MasterId = 1
               },


                new PurchaseDetail
                {
                    PurchaseDetailId = 3,
                    ProductId = 3,
                    ProductCode = "P03",
                    ModelId = 1,
                    ColorId = 2,
                    SizeId = 2,
                    EntryBy = usId,
                    EntryDate = DateTime.Now,
                    UnitPrice = 300,
                    DiscountRate = 5,
                    VatRate = 3,
                    NetAmount = 565,
                    UnitQuantity = 65,
                    TotalPrice = 4000,
                    Description = "dfas",
                    ExpiryDate = new DateTime(2021, 2, 2),
                    MasterId = 1
                }
           );

            // Add items in Cart
            modelBuilder.Entity<Cart>().HasData(
                new Cart
                {
                    CartId = 1,
                    CustomerId = 1
                }
            );

            // Add items in CartDetail
            modelBuilder.Entity<CartDetail>().HasData(
                new CartDetail
                {
                    CartDetailId = 1,
                    CartId = 1,
                    ProductId = 1,
                    Quantity = 4
                },
                new CartDetail
                {
                    CartDetailId = 2,
                    CartId = 1,
                    ProductId = 2,
                    Quantity = 3
                }
            );

            // Add items in Stock
            modelBuilder.Entity<Stock>().HasData(
                new Stock
                {
                    StockId = 1,
                    StockDate = DateTime.Now,
                    ProductCode = "P01",
                    ModelId = 1,
                    ColorId = 1,
                    SizeId = 1,
                    InQuantity = 100,
                    OutQuantity = 0,
                    InStockQuantity = 131,
                    StockPrice = 300,
                    ExpiryDate = DateTime.Now.AddYears(2),
                    LotNo = 1
                },
                new Stock
                {
                    StockId = 2,
                    StockDate = DateTime.Now,
                    ProductCode = "P02",
                    ModelId = 2,
                    ColorId = 2,
                    SizeId = 1,
                    InQuantity = 100,
                    OutQuantity = 0,
                    InStockQuantity = 131,
                    StockPrice = 300,
                    ExpiryDate = DateTime.Now.AddYears(2),
                    LotNo = 1
                },
                new Stock
                {
                    StockId = 3,
                    StockDate = DateTime.Now,
                    ProductCode = "P03",
                    ModelId = 1,
                    ColorId = 2,
                    SizeId = 2,
                    InQuantity = 100,
                    OutQuantity = 0,
                    InStockQuantity = 131,
                    StockPrice = 300,
                    ExpiryDate = DateTime.Now.AddYears(2),
                    LotNo = 1
                }
            );

            // Add items in StockDetails
            //modelBuilder.Entity<StockDetails>().HasData(
            //    new StockDetails
            //    {
            //        StockDetailsId = 1,
            //        StockId = 1,
            //        StockDate = new DateTime(2020, 09, 12),
            //        InQuantity = 100,
            //        OutQuantity = 80,
            //        StockPrice =540,
            //        BalancedQuantity = 50
            //    },
            //    new StockDetails
            //    {
            //        StockDetailsId = 2,
            //        StockId = 1,
            //        StockDate = new DateTime(2020, 09, 12),
            //        InQuantity = 100,
            //        OutQuantity = 70,
            //        StockPrice = 590,
            //        BalancedQuantity = 40
            //    }, new StockDetails
            //    {
            //        StockDetailsId = 3,
            //        StockId = 1,
            //        StockDate = new DateTime(2020, 09, 12),
            //        InQuantity = 130,
            //        OutQuantity = 130,
            //        StockPrice = 340,
            //        BalancedQuantity = 60
            //    }
            //);

            // Add items in WishList
            modelBuilder.Entity<WishList>().HasData(
                new WishList
                {
                    WishListId = 1,
                    CustomerId = 1,
                    ProductId = 3,
                    Quantity = 1
                }
            );
        }
    }
}
