using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RetailStoreDbContext.Models;
namespace RetailStoreDbContext.Data;
public class AppDbContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        var connString = config.GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlServer(connString);
    }
}
