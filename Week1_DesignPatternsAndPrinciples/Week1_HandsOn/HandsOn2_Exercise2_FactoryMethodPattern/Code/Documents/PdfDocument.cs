using System;
namespace HandsOn2_Exercise2_FactoryMethodPattern.Documents
{
    public class PdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening a PDF document.");
        }
    }
}