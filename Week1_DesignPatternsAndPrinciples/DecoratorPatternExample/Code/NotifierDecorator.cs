namespace DecoratorPatternExample
{
    public abstract class NotifierDecorator : Notifier
    {
        protected Notifier notifier;
        public NotifierDecorator(Notifier notifier)
        {
            this.notifier = notifier;
        }
        public virtual void Send()
        {
            notifier.Send();
        }
    }
}
