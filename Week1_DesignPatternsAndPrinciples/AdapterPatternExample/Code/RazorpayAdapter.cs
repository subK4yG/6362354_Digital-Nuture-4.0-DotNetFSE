namespace AdapterPatternExample
{
    public class RazorpayAdapter : IPaymentProcessor
    {
        private RazorpayGateway razor = new RazorpayGateway();
        public void ProcessPayment(double amount)
        {
            razor.PayViaRazor(amount);
        }
    }
}
