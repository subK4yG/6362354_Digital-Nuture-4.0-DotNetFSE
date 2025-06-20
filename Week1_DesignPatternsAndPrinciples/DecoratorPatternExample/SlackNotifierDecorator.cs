using System;
namespace DecoratorPatternExample
{
    public class SlackNotifierDecorator : NotifierDecorator
    {
        public SlackNotifierDecorator(Notifier notifier) : base(notifier) { }
        public override void Send()
        {
            base.Send();
            Console.WriteLine("Sending Slack");
        }
    }
}
