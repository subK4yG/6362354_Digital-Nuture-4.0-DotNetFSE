using System;
namespace AdapterPatternExample
{
    public class StripeGateway
    {
        public void MakeStripePayment(double amt)
        {
            Console.WriteLine($"Paid {amt} using Stripe.");
        }
    }
}
