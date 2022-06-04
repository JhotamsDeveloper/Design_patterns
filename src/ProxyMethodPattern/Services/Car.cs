using ProxyMethodPattern.Interfaces;

namespace ProxyMethodPattern.Services
{
    internal class Car : ICar
    {
        public void Drive() => Console.WriteLine("El automóvil esta siendo conducido");
    }
}
