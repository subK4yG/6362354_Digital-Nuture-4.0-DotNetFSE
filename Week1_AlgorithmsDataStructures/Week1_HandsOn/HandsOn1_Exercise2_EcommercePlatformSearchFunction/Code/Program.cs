using System;
namespace EcommercePlatformSearchFunction
{
    class Program
    {
        static Product LinearSearch(Product[] items, string name)
        {
            foreach (var p in items)
                if (p.ProductName == name) return p;
            return null;
        }
        static Product BinarySearch(Product[] items, string name)
        {
            int l = 0, r = items.Length - 1;
            while (l <= r)
            {
                int m = (l + r) / 2;
                int cmp = string.Compare(items[m].ProductName, name);
                if (cmp == 0) return items[m];
                else if (cmp < 0) l = m + 1;
                else r = m - 1;
            }
            return null;
        }
        static void Main(string[] args)
        {
            Product[] products = {
                new Product(1, "Bag", "Travel"),
                new Product(2, "Book", "Study"),
                new Product(3, "Laptop", "Electronics")
            };
            Array.Sort(products, (a, b) => a.ProductName.CompareTo(b.ProductName));
            var result = BinarySearch(products, "Laptop");
            Console.WriteLine(result != null ? "Found: " + result.ProductName : "Not Found");
        }
    }
}
