using Microsoft.EntityFrameworkCore;
using Bangthatzon.Models;
using Bangthatzon.Data;

    public class BangthatzonDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }


            public BangthatzonDbContext(DbContextOptions<BangthatzonDbContext> options) : base(options)
            {
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Category>().HasData(CategoryData.Categories);
                modelBuilder.Entity<User>().HasData(UserData.Users);
                modelBuilder.Entity<Product>().HasData(ProductData.Products);
                modelBuilder.Entity<Order>().HasData(OrderData.Orders);
                modelBuilder.Entity<PaymentType>().HasData(PaymentTypeData.PaymentTypes);

            }
    }


