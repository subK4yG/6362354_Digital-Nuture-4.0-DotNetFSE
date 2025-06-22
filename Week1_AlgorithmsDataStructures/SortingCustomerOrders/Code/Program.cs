using System;
using System.Collections.Generic;
class Order
{
    public int orderId;
    public string customerName;
    public double totalPrice;
    public Order(int id, string name, double price)
    {
        orderId = id;
        customerName = name;
        totalPrice = price;
    }
}
class Program
{
    static void BubbleSort(List<Order> orders)
    {
        int n = orders.Count;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (orders[j].totalPrice > orders[j + 1].totalPrice)
                {
                    var temp = orders[j];
                    orders[j] = orders[j + 1];
                    orders[j + 1] = temp;
                }
    }
    static void QuickSort(List<Order> orders, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(orders, low, high);
            QuickSort(orders, low, pi - 1);
            QuickSort(orders, pi + 1, high);
        }
    }
    static int Partition(List<Order> orders, int low, int high)
    {
        double pivot = orders[high].totalPrice;
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (orders[j].totalPrice < pivot)
            {
                i++;
                var temp = orders[i];
                orders[i] = orders[j];
                orders[j] = temp;
            }
        }
        var temp2 = orders[i + 1];
        orders[i + 1] = orders[high];
        orders[high] = temp2;
        return i + 1;
    }
    static void Print(List<Order> orders)
    {
        foreach (var o in orders)
            Console.WriteLine($"{o.orderId} - {o.customerName} - Rs.{o.totalPrice}");
    }
    static void Main()
    {
        var orders = new List<Order>
        {
            new Order(1010, "SHyam", 2500),
            new Order(1020, "Sita", 4500),
            new Order(1030, "Ram", 6500),
            new Order(1040, "Devi", 3000)
        };
        Console.WriteLine("Before Sorting:");
        Print(orders);
        QuickSort(orders, 0, orders.Count - 1); 
        Console.WriteLine("\nAfter Sorting by totalPrice:");
        Print(orders);
    }
}
