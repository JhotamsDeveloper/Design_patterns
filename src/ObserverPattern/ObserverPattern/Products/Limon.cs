using ObserverPattern.Abstractor;

namespace ObserverPattern.Products
{
    public class Limon : Fruits
    {
        public Limon(double pricePerKg) : base(pricePerKg)
        {
        }
    }
}
