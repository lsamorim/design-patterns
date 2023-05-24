namespace SOLID.OpenClosed
{
    public class ProductFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> specification)
        {
            foreach (var item in items)
            {
                if (specification.IsSatisfiedBy(item))
                    yield return item;
            }
        }
    }
}
