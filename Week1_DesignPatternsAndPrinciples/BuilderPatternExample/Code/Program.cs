using System;
namespace BuilderPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer gamingPC = new Computer.Builder()
                .SetCPU("Intel Core i9")
                .SetRAM("32GB")
                .SetStorage("1TB SSD")
                .SetGPU("NVIDIA RTX 4090")
                .Build();
            Computer officePC = new Computer.Builder()
                .SetCPU("Intel Core i5")
                .SetRAM("8GB")
                .SetStorage("512GB SSD")
                .Build();
            Console.WriteLine("Gaming PC: " + gamingPC);
            Console.WriteLine("Office PC: " + officePC);
        }
    }
}