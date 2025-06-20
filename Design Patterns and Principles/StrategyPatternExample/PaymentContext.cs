namespace StrategyPatternExample
{
    public class PaymentContext
    {
        private IPaymentStrategy strategy;
        public PaymentContext(IPaymentStrategy strategy)
        {
            this.strategy = strategy;
        }
        public void ExecutePayment(double amount)
        {
            strategy.Pay(amount);
        }
    }
}