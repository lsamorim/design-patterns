namespace SOLID.OpenClosed
{
    public class Product
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }

        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }

    public enum Color
    {
        White, Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Large, Huge
    }
}
