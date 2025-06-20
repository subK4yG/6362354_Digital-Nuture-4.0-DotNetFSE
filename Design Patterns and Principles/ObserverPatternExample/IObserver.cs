namespace ObserverPatternExample
{
    public interface IObserver
    {
        void Update(string stock, double price);
    }
}
