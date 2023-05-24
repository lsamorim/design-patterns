namespace SOLID.InterfaceSegregation
{
    public interface IBadMachine
    {
        void Print(Document document);

        void Scan(Document document);

        void Fax(Document document);
    }
}
