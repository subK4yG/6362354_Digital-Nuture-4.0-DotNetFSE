using System;
namespace DecoratorPatternExample
{
    public class EmailNotifier : Notifier
    {
        public void Send()
        {
            Console.WriteLine("Sending Email");
        }
    }
}
