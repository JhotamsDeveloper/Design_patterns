using FactoryMethodAbstractPattern.Interfaces;

namespace FactoryMethodAbstractPattern.Services
{
    public class MarinaraSauce : ISauce
    {
        public MarinaraSauce()
        {
            Console.WriteLine("Agregando la salsa marinara");
        }
    }
}