using BuilderPattern.Builder;
using BuilderPattern.Product;

namespace BuilderPattern.Concrete
{
    public class ConTypicalFood : IFoodDishes
    {
        private PTypicalFood _preparedBeans;

        public ConTypicalFood()
        {
            Reset();
        }

        public string SetName(string name) => _preparedBeans.Name = name;

        public void AddIngredients(string ingredient)
        {
            if (_preparedBeans.Ingredients == null)
                _preparedBeans.Ingredients = new List<string>();

            _preparedBeans.Ingredients.Add(ingredient);
        }

        public void Mix()
        {
            string ingredients = _preparedBeans.Ingredients.Aggregate((i, j) => $"{i},{Environment.NewLine}{j}");
            string culture = _preparedBeans.Culture == null ? string.Empty : $" reconocido en la cultura {_preparedBeans.Culture}";
            _preparedBeans.Result = $"Plato típico llamado {_preparedBeans.Name.ToUpper()}{culture} con los siguientes ingredientes: " +
                $"{Environment.NewLine}{ingredients}";

            Console.WriteLine("Preparando plato");
        }

        public void Reset() => _preparedBeans = new PTypicalFood();

        public string SetCulture(string culture) => _preparedBeans.Culture = culture;

        public string SetInformation(string information) => _preparedBeans.Information = information;
        
        public void Rest(int time)
        {
            Thread.Sleep(time);
            Console.WriteLine("Plato preparado");
        }

        public PTypicalFood GetTypicalDish() => _preparedBeans;

        public double GetPrice(double price) => (double)(_preparedBeans.Price = price);
    }
}
