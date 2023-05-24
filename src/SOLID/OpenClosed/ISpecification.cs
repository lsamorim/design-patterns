namespace SOLID.OpenClosed
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T entity);
    }
}
