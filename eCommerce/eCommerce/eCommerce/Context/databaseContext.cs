using eCommerce.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace eCommerce.Context
{
    public class databaseContext: IdentityDbContext<User, Role, Guid>
    {
        public databaseContext(DbContextOptions<databaseContext> options):base(options)
        {

        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public DbSet<PurchaseMaster> PurchaseMasters { get; set; }
        public DbSet<SalesDetail> SalesDetails { get; set; }
        public DbSet<SalesMaster> SalesMasters { get; set; }
        public DbSet<ShippingAddress> ShippingAddresses { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Thana> Thanas { get; set; }
        public DbSet<Unit> Units { get; set; }
        //public DbSet<StockDetails> StockDetails { get; set; }
        public DbSet<WishList> WisthLists { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Currier> Currier { get; set; }
        public DbSet<ModelTbl> ModelTbls { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
