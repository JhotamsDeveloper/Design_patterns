using ObserverPattern.Abstractor;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Client
{
    public class Restaurant : IRestaurant
    {
        private string _name;
        private double _purchaseThreshold;

        public Restaurant(string name, double purchaseThreshold)
        {
            _name = name;
            _purchaseThreshold = purchaseThreshold;
        }

        public void Update(Fruits fruits)
        {
            Console.Write($"Notificando a {_name} que el precio de {fruits.GetType().Name} cambio a {fruits.PricePerKg}");

            if (fruits.PricePerKg < _purchaseThreshold)
            {
                Console.WriteLine("");
                Console.WriteLine($"{_name} quiere comprar algunos {fruits.GetType().Name}es!");
            }
        }
    }
}
