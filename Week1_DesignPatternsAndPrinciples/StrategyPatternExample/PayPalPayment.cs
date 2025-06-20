using System;
namespace StrategyPatternExample
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal.");
        }
    }
}