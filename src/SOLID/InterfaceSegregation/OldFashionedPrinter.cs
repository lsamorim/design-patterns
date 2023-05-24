namespace SOLID.InterfaceSegregation
{
    public class OldFashionedPrinter : IPrinter
    {
        public void Print(Document document)
        {
            Console.WriteLine($" - {nameof(OldFashionedPrinter)} Printing document: {document}");
        }
    }
}
