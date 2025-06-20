using System.Collections.Generic;
namespace ObserverPatternExample
{
    public class StockMarket : IStock
    {
        private List<IObserver> observers = new List<IObserver>();
        public void Register(IObserver o) => observers.Add(o);
        public void Deregister(IObserver o) => observers.Remove(o);
        public void Notify(string stock, double price)
        {
            foreach (var o in observers)
                o.Update(stock, price);
        }
        public void PriceChanged(string stock, double price)
        {
            Notify(stock, price);
        }
    }
}
