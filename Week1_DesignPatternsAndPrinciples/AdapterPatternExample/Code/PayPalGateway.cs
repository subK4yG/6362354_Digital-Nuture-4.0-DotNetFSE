using System;
namespace AdapterPatternExample
{
    public class PayPalGateway
    {
        public void PayWithPayPal(double amt)
        {
            Console.WriteLine($"Paid {amt} using PayPal.");
        }
    }
}
