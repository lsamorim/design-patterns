namespace SOLID.OpenClosed
{
    public class OpenClosedExample
    {
        public static void Execute()
        {
            var shirt = new Product("Nice shirt", Color.White, Size.Large);
            var book = new Product("Clean Code", Color.Blue, Size.Small);
            var horse = new Product("Loyal Horse", Color.Red, Size.Large);
            var tree = new Product("Yuuge Tree", Color.Green, Size.Huge);

            var products = new List<Product>()
            {
                shirt, book, horse, tree
            };

            var badFilter = new BadProductFilter();

            foreach (var product in badFilter.FilterBySize(products, Size.Large))
            {
                Console.WriteLine($" - {product.Name} is Large");
            }

            Console.ReadKey();
        }
    }
}
