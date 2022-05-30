using FactoryMethodAbstractPattern.Interfaces;

namespace FactoryMethodAbstractPattern.Services
{
    public class Mushroom : IVeggie
    {
        public Mushroom()
        {
            Console.WriteLine("Agregando los hongos");
        }
    }
}