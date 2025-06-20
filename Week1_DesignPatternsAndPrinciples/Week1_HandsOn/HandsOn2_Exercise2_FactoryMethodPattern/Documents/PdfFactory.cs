namespace HandsOn2_Exercise2_FactoryMethodPattern.Documents
{
    public class PdfFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new PdfDocument();
        }
    }
}