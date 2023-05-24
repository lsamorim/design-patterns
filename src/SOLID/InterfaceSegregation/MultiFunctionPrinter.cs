namespace SOLID.InterfaceSegregation
{
    public class MultiFunctionPrinter : IPrinter, IScanner
    {
        public void Print(Document document)
        {
            Console.WriteLine($" - {nameof(MultiFunctionPrinter)} Printing document: {document}");
        }

        public void Scan(Document document)
        {
            Console.WriteLine($" - {nameof(MultiFunctionPrinter)} Scanning document: {document}");
        }
    }
}
