using CompositePattern.Abstrations;

namespace CompositePattern.Services
{
    public class SimpleProduct : Product
    {
        public SimpleProduct(string name, int price) : base(name, price)
        {
        }

        public override void Add(Product product)
        {
            // Operación no se puede realizar porqué es el elemento que se encuentra mas abajo en la jerarquía
        }

        public override string GetPrice()
        {
            return $"El precio de {Name} es {Price:N2}";
        }

        public override void Remove(Product product)
        {
            // Operación no se puede realizar porqué es el elemento que se encuentra mas abajo en la jerarquía
        }
    }
}
