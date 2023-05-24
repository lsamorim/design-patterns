namespace SOLID.OpenClosed
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _firstSpecification, _secondSpecification;

        public AndSpecification(ISpecification<T> firstSpecification, ISpecification<T> secondSpecification)
        {
            _firstSpecification = firstSpecification;
            _secondSpecification = secondSpecification;
        }

        public bool IsSatisfiedBy(T entity)
        {
            return _firstSpecification.IsSatisfiedBy(entity) && _secondSpecification.IsSatisfiedBy(entity);
        }
    }
}
