using System;
namespace ObserverPatternExample
{
    public class WebApp : IObserver
    {
        public void Update(string stock, double price)
        {
            Console.WriteLine($"[Web] {stock} updated to {price}");
        }
    }
}