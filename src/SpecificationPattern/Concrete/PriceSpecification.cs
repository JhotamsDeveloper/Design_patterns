using SpecificationPattern.Interfaz;
using SpecificationPattern.Models;

namespace SpecificationPattern.Concrete
{
    public sealed class PriceSpecification : ISpecification<Product>
    {
        private readonly decimal _maxPrice;

        public PriceSpecification(decimal maxPrice)
        {
            _maxPrice = maxPrice;
        }

        public bool IsSatisfiedBy(Product item)
        {
            return item.Price <= _maxPrice;
        }
    }
}
