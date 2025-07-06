using System;
using Microsoft.EntityFrameworkCore;
using RetailStoreRetrieve.Data;
using RetailStoreRetrieve.Models;
Console.WriteLine("Lab 5: Retrieving Data from the Database");
var options = new DbContextOptionsBuilder<AppDbContext>()
    .UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Week3Lab5RetrieveDb;Trusted_Connection=True;TrustServerCertificate=True;")
    .Options;
using var context = new AppDbContext(options);
if (!context.Products.Any())
{
    var cat = new Category { Name = "Electronics" };
    var prod = new Product { Name = "Smartphone", Price = 25000, Category = cat };
    context.Categories.Add(cat);
    context.Products.Add(prod);
    context.SaveChanges();
    Console.WriteLine("Seeded initial product data.");
}
var products = await context.Products.Include(p => p.Category).ToListAsync();
foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price} - Category: {p.Category?.Name}");
}
var productById = await context.Products.FindAsync(1);
Console.WriteLine($"Found: {productById?.Name}");
var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 5000);
Console.WriteLine($"Expensive: {expensive?.Name}");
Console.WriteLine("Lab 5 retrieval finished.");
