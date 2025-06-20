using System;
namespace ObserverPatternExample
{
    public class MobileApp : IObserver
    {
        public void Update(string stock, double price)
        {
            Console.WriteLine($"[Mobile] {stock} updated to {price}");
        }
    }
}
