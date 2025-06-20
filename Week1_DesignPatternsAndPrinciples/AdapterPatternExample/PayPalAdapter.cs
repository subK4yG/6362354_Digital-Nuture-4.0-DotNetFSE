namespace AdapterPatternExample
{
    public class PayPalAdapter : IPaymentProcessor
    {
        private PayPalGateway paypal = new PayPalGateway();
        public void ProcessPayment(double amount)
        {
            paypal.PayWithPayPal(amount);
        }
    }
}
