using System;
namespace HandsOn2_Exercise2_FactoryMethodPattern.Documents
{
    public class ExcelDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening an Excel document.");
        }
    }
}