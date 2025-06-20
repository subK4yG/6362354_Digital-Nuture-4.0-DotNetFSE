using System;
namespace HandsOn2_Exercise2_FactoryMethodPattern.Documents
{
    public class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening a Word document.");
        }
    }
}