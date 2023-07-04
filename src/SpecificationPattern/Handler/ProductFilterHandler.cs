using SpecificationPattern.Interfaz;
using SpecificationPattern.Models;

namespace SpecificationPattern.Handler;

public static class ProductFilterHandler
{
    public static List<Product> FilterBySpecification(List<Product> products, ISpecification<Product> specification)
    {
        List<Product> filtered = new();
        foreach (Product product in products)
        {
            if (specification.IsSatisfiedBy(product))
            {
                filtered.Add(product);
            }
        }

        return filtered;
    }
}
