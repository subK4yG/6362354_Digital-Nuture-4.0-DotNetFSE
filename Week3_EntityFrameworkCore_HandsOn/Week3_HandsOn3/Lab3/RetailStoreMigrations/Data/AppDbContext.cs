using Microsoft.EntityFrameworkCore;
using RetailStoreMigrations.Models;
namespace RetailStoreMigrations.Data;
public class AppDbContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Week3Lab3Db;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
