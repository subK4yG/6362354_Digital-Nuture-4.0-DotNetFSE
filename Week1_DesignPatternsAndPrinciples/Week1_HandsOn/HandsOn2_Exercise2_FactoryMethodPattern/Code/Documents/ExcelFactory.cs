namespace HandsOn2_Exercise2_FactoryMethodPattern.Documents
{
    public class ExcelFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new ExcelDocument();
        }
    }
}