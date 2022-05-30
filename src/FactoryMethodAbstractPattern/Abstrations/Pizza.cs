using FactoryMethodAbstractPattern.Interfaces;

namespace FactoryMethodAbstractPattern.Abstrations
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        protected IDough Dough;
        protected ISauce Sauce;
        protected ICheese Cheese;
        protected List<IVeggie> Veggies = new List<IVeggie>();

        public abstract void Prepare();

        public void Bake() => Console.WriteLine($"Cocinar por 20 min");
        public void Cut() => Console.WriteLine($"Pizza fue cortada en partes iguales");
        public void Box() => Console.WriteLine($"Pizza colocada en caja oficial");
    }
}
