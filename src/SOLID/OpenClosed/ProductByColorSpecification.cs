namespace SOLID.OpenClosed
{
    public class ProductByColorSpecification : ISpecification<Product>
    {
        private readonly Color _color;

        public ProductByColorSpecification(Color color)
        {
            _color = color;
        }

        public bool IsSatisfiedBy(Product entity)
        {
            return entity.Color == _color;
        }
    }
}
