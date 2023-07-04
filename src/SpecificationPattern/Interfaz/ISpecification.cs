namespace SpecificationPattern.Interfaz;

public interface ISpecification<T>
{
    bool IsSatisfiedBy(T item);
}
