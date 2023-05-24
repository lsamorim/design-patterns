namespace SOLID.InterfaceSegregation
{
    public class BadOldFashionedPrinter : IBadMachine
    {
        public void Print(Document document)
        {
            Console.WriteLine($" - {nameof(BadOldFashionedPrinter)} Printing document: {document}");
        }

        public void Scan(Document document)
        {
            throw new NotImplementedException($" - {nameof(BadOldFashionedPrinter)} !This machine cannot scan documents. Sorry!");
        }

        public void Fax(Document document)
        {
            throw new NotImplementedException($" - {nameof(BadOldFashionedPrinter)} !This machine cannot send fax documents. Sorry!");
        }
    }
}
