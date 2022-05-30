using BuilderPattern.Product;

namespace BuilderPattern.Builder
{
    public interface IFoodDishes : IMain
    {
        public string SetName(string name);
        public string SetCulture(string culture);
        public string SetInformation(string information);
        public double GetPrice(double price);

        public PTypicalFood GetTypicalDish();
    }
}
