using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RetailStoreRetrieve.Models;

namespace RetailStoreRetrieve.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();
}
