namespace EcommercePlatformSearchFunction
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public Product(int id, string name, string cat)
        {
            ProductId = id;
            ProductName = name;
            Category = cat;
        }
    }
}
