using System;
using SingletonPatternExample.src;
namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            logger1.Log("First message");
            Logger logger2 = Logger.GetInstance();
            logger2.Log("Second message");
            if (logger1 == logger2)
            {
                Console.WriteLine("Both logger instances are the same (Singleton works).");
            }
            else
            {
                Console.WriteLine("Different instances (Singleton failed).");
            }
        }
    }
}