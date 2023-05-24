namespace SOLID.LiskovSubstitution
{
    public class BadSquare : BadRectangle
    {
        public new int Width { set { base.Width = base.Height = value; } }

        public new int Height { set { base.Width = base.Height = value; } }
    }
}
