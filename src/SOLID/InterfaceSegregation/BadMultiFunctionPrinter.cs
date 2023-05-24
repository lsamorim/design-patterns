namespace SOLID.InterfaceSegregation
{
    public class BadMultiFunctionPrinter : IBadMachine
    {
        public void Print(Document document)
        {
            Console.WriteLine($" - {nameof(BadMultiFunctionPrinter)} Printing document: {document}");
        }
        
        public void Scan(Document document)
        {
            Console.WriteLine($" - {nameof(BadMultiFunctionPrinter)} Scanning document: {document}");
        }

        public void Fax(Document document)
        {
            Console.WriteLine($" - {nameof(BadMultiFunctionPrinter)} Sending fax for document: {document}");
        }
    }
}
