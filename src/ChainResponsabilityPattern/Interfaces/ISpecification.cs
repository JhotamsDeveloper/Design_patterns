namespace ChainResponsabilityPattern.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatified(T item);
    }
}
