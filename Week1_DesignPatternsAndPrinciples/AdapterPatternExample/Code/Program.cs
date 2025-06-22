using System;
namespace AdapterPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor paypal = new PayPalAdapter();
            IPaymentProcessor stripe = new StripeAdapter();
            IPaymentProcessor razor = new RazorpayAdapter();
            paypal.ProcessPayment(100);
            stripe.ProcessPayment(250);
            razor.ProcessPayment(300);
        }
    }
}
