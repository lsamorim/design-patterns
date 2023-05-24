namespace SOLID.LiskovSubstitution
{
    public static class LiskovSubstitutionExample
    {
        private static string Title = "Liskov Substitution Principle";

        public static void Execute()
        {
            Console.WriteLine($"*** Start: {Title} ***\n");

            // Bad
            Console.WriteLine($"** Bad approach **\n");
            BadRectangle badRectange = new BadRectangle()
            {
                Width = 10,
                Height = 20,
            };
            BadRectangle badSquare = new BadSquare();
            badSquare.Width = 10;

            Console.WriteLine($"{badRectange} has area {Area(badRectange)}");
            Console.WriteLine($"{badSquare} has area {Area(badSquare)}");

            Console.ReadKey();

            // Good
            Console.WriteLine($"\n** Good approach **\n");
            Rectangle rectange = new Rectangle()
            {
                Width = 10,
                Height = 20,
            };
            Rectangle square = new Square();
            square.Width = 10;

            Console.WriteLine($"{rectange} has area {Area(rectange)}");
            Console.WriteLine($"{square} has area {Area(square)}");

            Console.WriteLine($"\n*** End: {Title} ***\n");
            Console.ReadKey();
        }

        private static int Area(BadRectangle r) => r.Width * r.Height;
        private static int Area(Rectangle r) => r.Width * r.Height;
    }
}
