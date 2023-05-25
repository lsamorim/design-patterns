namespace SOLID.OpenClosed
{
    public class OpenClosedExample
    {
        public static string Title = "Open Closed Principle";

        public static void Execute()
        {
            Console.WriteLine($"*** Start: {Title} ***\n");

            var shirt = new Product("Nice shirt", Color.White, Size.Large);
            var book = new Product("Clean Code", Color.Blue, Size.Small);
            var horse = new Product("Loyal Horse", Color.Red, Size.Large);
            var tree = new Product("Yuuge Tree", Color.Green, Size.Huge);

            var products = new List<Product>()
            {
                shirt, book, horse, tree
            };

            // Bad
            Console.WriteLine($"** Bad approach **\n");
            var badFilter = new BadProductFilter();
            
            foreach (var product in badFilter.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($" - {product.Name} is Green");
            }

            foreach (var product in badFilter.FilterBySize(products, Size.Large))
            {
                Console.WriteLine($" - {product.Name} is Large");
            }

            foreach (var product in badFilter.FilterByColorAndSize(products, Color.Red, Size.Large))
            {
                Console.WriteLine($" - {product.Name} is Red and Large");
            }

            Console.ReadKey();

            // Good
            Console.WriteLine($"\n** Good approach **\n");
            var filter = new ProductFilter();

            var productByGreenColorSpecification = new ProductByColorSpecification(Color.Green);
            foreach (var product in filter.Filter(products, productByGreenColorSpecification))
            {
                Console.WriteLine($" - {product.Name} is Green");
            }

            var productByLargeSizeSpecification = new ProductBySizeSpecification(Size.Large);
            foreach (var product in filter.Filter(products, productByLargeSizeSpecification))
            {
                Console.WriteLine($" - {product.Name} is Large");
            }

            var redAndLargeSpecification = new AndSpecification<Product>(
                new ProductByColorSpecification(Color.Red), new ProductBySizeSpecification(Size.Large));
            foreach (var product in filter.Filter(products, redAndLargeSpecification))
            {
                Console.WriteLine($" - {product.Name} is Red and Large");
            }

            Console.WriteLine($"\n*** End: {Title} ***\n");
            Console.ReadKey();
        }
    }
}
