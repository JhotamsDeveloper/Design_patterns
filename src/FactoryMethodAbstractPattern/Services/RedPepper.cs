using FactoryMethodAbstractPattern.Interfaces;

namespace FactoryMethodAbstractPattern.Services
{
    public class RedPepper : IVeggie
    {
        public RedPepper()
        {
            Console.WriteLine("Agregando la pimienta roja");
        }
    }
}