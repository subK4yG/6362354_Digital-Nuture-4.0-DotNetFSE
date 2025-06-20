using System;
namespace DecoratorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Notifier notify = new SlackNotifierDecorator(
                                 new SMSNotifierDecorator(
                                     new EmailNotifier()));
            notify.Send();
        }
    }
}
