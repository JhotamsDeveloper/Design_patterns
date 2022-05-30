using FactoryMethodAbstractPattern.Interfaces;

namespace FactoryMethodAbstractPattern.Services
{
    public class Onion : IVeggie
    {
        public Onion()
        {
            Console.WriteLine("Agregando la cebolla");
        }
    }
}