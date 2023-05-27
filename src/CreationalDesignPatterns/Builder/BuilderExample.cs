using System.Text;

namespace CreationalDesignPatterns.Builder
{
    public class BuilderExample
    {
        public static string Title = "Creational: Builder";

        public static void Execute()
        {
            Console.WriteLine($"*** Start: {Title} ***\n");

            // Bad
            Console.WriteLine($"** Bad approach **\n");
            var words = new[] { "hello", "world" };

            var sb = new StringBuilder();
            sb.Append("<ul>");
            foreach (var word in words)
            {
                sb.Append($"<li>{word}</li>");
            }
            sb.Append("</ul>");
            Console.WriteLine(sb);

            Console.ReadKey();

            // Good
            Console.WriteLine($"\n** Good approach **\n");
            var htmlBuilder = new HTMLBuilder("ul")
                .AddChild("li", "hello")
                .AddChild("li", "world");
            Console.WriteLine(htmlBuilder.ToString());

            Console.WriteLine($"\n*** End: {Title} ***\n");
            Console.ReadKey();
        }
    }
}
