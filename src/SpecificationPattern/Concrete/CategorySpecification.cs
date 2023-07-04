using SpecificationPattern.Interfaz;
using SpecificationPattern.Models;

namespace SpecificationPattern.Concrete;

public sealed class CategorySpecification : ISpecification<Product>
{
    private readonly string _category;

    public CategorySpecification(string category)
    {
        _category = category;
    }

    public bool IsSatisfiedBy(Product item)
    {
        return item.Category.Equals(_category, StringComparison.OrdinalIgnoreCase);
    }
}
