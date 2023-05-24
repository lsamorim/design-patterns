namespace SOLID.LiskovSubstitution
{
    public class BadRectangle
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
    }
}
