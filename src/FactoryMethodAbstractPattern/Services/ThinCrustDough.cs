using FactoryMethodAbstractPattern.Interfaces;

namespace FactoryMethodAbstractPattern.Services
{
    public class ThinCrustDough : IDough
    {
        public ThinCrustDough()
        {
            Console.WriteLine("Agregando la masa");
        }
    }
}