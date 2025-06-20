namespace AdapterPatternExample
{
    public class StripeAdapter : IPaymentProcessor
    {
        private StripeGateway stripe = new StripeGateway();
        public void ProcessPayment(double amount)
        {
            stripe.MakeStripePayment(amount);
        }
    }
}
