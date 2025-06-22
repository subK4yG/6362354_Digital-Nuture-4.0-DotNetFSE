using System;
using HandsOn2_Exercise2_FactoryMethodPattern.Documents;
namespace HandsOn2_Exercise2_FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory wordFactory = new WordFactory();
            IDocument wordDoc = wordFactory.CreateDocument();
            wordDoc.Open();
            DocumentFactory pdfFactory = new PdfFactory();
            IDocument pdfDoc = pdfFactory.CreateDocument();
            pdfDoc.Open();
            DocumentFactory excelFactory = new ExcelFactory();
            IDocument excelDoc = excelFactory.CreateDocument();
            excelDoc.Open();
        }
    }
}