using Microsoft.EntityFrameworkCore;
using RetailStoreSeedData.Models;
namespace RetailStoreSeedData.Data;
public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Week3Lab4Db;Trusted_Connection=True;TrustServerCertificate=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "groceries" },
            new Category { Id = 2, Name = "electronics" }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Rice Bag", Price = 1200, CategoryId = 1 },
            new Product { Id = 2, Name = "Laptop", Price = 65000, CategoryId = 2 }
        );
    }
}
