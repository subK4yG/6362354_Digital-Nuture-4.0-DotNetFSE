using System;
namespace DecoratorPatternExample
{
    public class SMSNotifierDecorator : NotifierDecorator
    {
        public SMSNotifierDecorator(Notifier notifier) : base(notifier) { }
        public override void Send()
        {
            base.Send();
            Console.WriteLine("Sending SMS");
        }
    }
}
