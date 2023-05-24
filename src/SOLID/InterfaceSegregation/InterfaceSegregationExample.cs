namespace SOLID.InterfaceSegregation
{
    public static class InterfaceSegregationExample
    {
        private static string Title = "Interface Segregation Principle";

        public static void Execute()
        {
            Console.WriteLine($"*** Start: {Title} ***\n");

            var document = new Document("Test.txt");

            // Bad
            Console.WriteLine($"** Bad approach **\n");
            try
            {
                var badMultiFunctionPrinter = new BadMultiFunctionPrinter();
                badMultiFunctionPrinter.Print(document);
                badMultiFunctionPrinter.Scan(document);
                badMultiFunctionPrinter.Fax(document);

                Console.ReadKey();

                var badOldFashionedPrinter = new BadOldFashionedPrinter();
                badOldFashionedPrinter.Print(document);
                badOldFashionedPrinter.Scan(document);
                badOldFashionedPrinter.Fax(document);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

            // Good
            Console.WriteLine($"\n** Good approach **\n");
            var multiFunctionPrinter = new MultiFunctionPrinter();
            multiFunctionPrinter.Print(document);
            multiFunctionPrinter.Scan(document);

            Console.ReadKey();

            var oldFashionedPrinter = new OldFashionedPrinter();
            oldFashionedPrinter.Print(document);

            Console.WriteLine($"\n*** End: {Title} ***\n");
            Console.ReadKey();
        }
    }
}
