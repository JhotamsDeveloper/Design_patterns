using CompositePattern.Abstrations;

namespace CompositePattern.Services
{
    public class CompositeProduct : Product
    {
        List<Product> _products = new();
        public CompositeProduct(string name) : base(name, 0)
        {
        }

        public override void Add(Product product)
        {
            _products.Add(product);
        }

        public override string GetPrice()
        {
            return $"El precio {Name} es {_products.Sum(p => p.Price):N2}";
        }

        public override void Remove(Product product)
        {
            _products.Remove(product);
        }
    }
}
