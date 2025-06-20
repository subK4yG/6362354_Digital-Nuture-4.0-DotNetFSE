using System;
namespace FactoryMethodPattern.Documents
{
    public class ExcelDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening an Excel document.");
        }
    }
}