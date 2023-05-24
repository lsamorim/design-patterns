namespace SOLID.OpenClosed
{
    public class BadProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (Product product in products)
            {
                if (product.Size == size)
                    yield return product;
            }
        }
    }
}
