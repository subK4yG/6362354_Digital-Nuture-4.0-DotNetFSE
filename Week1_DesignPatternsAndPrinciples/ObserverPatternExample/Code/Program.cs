using System;
namespace ObserverPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var market = new StockMarket();
            var mobile = new MobileApp();
            var web = new WebApp();
            market.Register(mobile);
            market.Register(web);
            market.PriceChanged("AAPL", 186.4);
            market.PriceChanged("GOOG", 2760.2);
        }
    }
}
