namespace SOLID.OpenClosed
{
    public class ProductBySizeSpecification : ISpecification<Product>
    {
        private readonly Size _size;

        public ProductBySizeSpecification(Size size)
        {
            _size = size;
        }

        public bool IsSatisfiedBy(Product entity)
        {
            return entity.Size == _size;
        }
    }
}
