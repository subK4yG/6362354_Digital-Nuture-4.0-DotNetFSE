using System;
namespace StrategyPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var credit = new PaymentContext(new CreditCardPayment());
            credit.ExecutePayment(100);
            var paypal = new PaymentContext(new PayPalPayment());
            paypal.ExecutePayment(200);
        }
    }
}
