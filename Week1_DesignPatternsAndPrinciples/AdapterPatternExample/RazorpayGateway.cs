using System;
namespace AdapterPatternExample
{
    public class RazorpayGateway
    {
        public void PayViaRazor(double amt)
        {
            Console.WriteLine($"Paid {amt} using Razorpay.");
        }
    }
}
