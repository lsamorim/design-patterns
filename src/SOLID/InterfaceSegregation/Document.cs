namespace SOLID.InterfaceSegregation
{
    public class Document
    {
        private readonly string _name;

        public Document(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return $"Document {_name}";
        }
    }


}
