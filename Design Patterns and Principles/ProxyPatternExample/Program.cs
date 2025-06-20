using System;
namespace ProxyPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Image img1 = new ProxyImage("photo1.jpg");
            img1.Display(); 
            Console.WriteLine("---");
            img1.Display(); 
        }
    }
}
