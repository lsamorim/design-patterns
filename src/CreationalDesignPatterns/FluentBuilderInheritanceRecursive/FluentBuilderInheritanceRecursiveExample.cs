namespace CreationalDesignPatterns.FluentBuilderInheritanceRecursive
{
    public class FluentBuilderInheritanceRecursiveExample
    {
        public static string Title = "Creational: Fluent Builder Inheritance with Recursive";

        public static void Execute()
        {
            Console.WriteLine($"*** Start: {Title} ***\n");

            // Good
            var person = Person
                .New()
                .Called("Lucas")
                .WorksAsA("Programmer")
                .Build();

            Console.WriteLine(person);

            Console.WriteLine($"\n*** End: {Title} ***\n");
            Console.ReadKey();
        }
    }
}
