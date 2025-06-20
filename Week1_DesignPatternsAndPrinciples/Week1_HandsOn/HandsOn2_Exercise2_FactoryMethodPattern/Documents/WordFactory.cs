namespace HandsOn2_Exercise2_FactoryMethodPattern.Documents
{
    public class WordFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new WordDocument();
        }
    }
}