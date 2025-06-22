using System;
using System.Collections.Generic;
namespace InventoryManagementSystem
{
    class Program
    {
        static Dictionary<int, Product> inventory = new();
        static void Add(Product p) => inventory[p.ProductId] = p;
        static void Update(int id, int qty, double price)
        {
            if (inventory.ContainsKey(id))
            {
                inventory[id].Quantity = qty;
                inventory[id].Price = price;
            }
        }
        static void Delete(int id) => inventory.Remove(id);
        static void Main(string[] args)
        {
            Add(new Product(1, "Keyboard", 10, 499.99));
            Add(new Product(2, "Mouse", 20, 299.49));
            Update(1, 12, 479.99);
            Delete(2);
            foreach (var p in inventory.Values)
                Console.WriteLine($"{p.ProductId} - {p.ProductName} - {p.Quantity} - Rs.{p.Price}");
        }
    }
}
