using FactoryMethodAbstractPattern.Interfaces;

namespace FactoryMethodAbstractPattern.Services
{
    public class Garlic : IVeggie
    {
        public Garlic()
        {
            Console.WriteLine("Agregando el Ajo");
        }
    }
}