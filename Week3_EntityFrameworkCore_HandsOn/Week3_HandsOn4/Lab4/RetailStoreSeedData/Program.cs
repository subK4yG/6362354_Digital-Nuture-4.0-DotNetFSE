using System;
using Microsoft.EntityFrameworkCore;
using RetailStoreSeedData.Data;
var context = new AppDbContext();
await context.Database.MigrateAsync();
Console.WriteLine("Lab4: Seed data added successfully.");
