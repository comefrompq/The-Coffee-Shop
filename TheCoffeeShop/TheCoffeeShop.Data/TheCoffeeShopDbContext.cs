using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using TheCoffeeShop.Data.Models;

namespace TheCoffeeShop.Data
{
    public class TheCoffeeShopDbContext:IdentityDbContext
    {
        public TheCoffeeShopDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>().HasKey(sc => new { sc.OrderId, sc.ProductId });
        }
    }
}
