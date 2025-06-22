namespace InventoryManagementSystem
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product(int id, string name, int qty, double price)
        {
            ProductId = id;
            ProductName = name;
            Quantity = qty;
            Price = price;
        }
    }
}
