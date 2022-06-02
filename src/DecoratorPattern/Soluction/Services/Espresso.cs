using Soluction.Interfaces;

namespace Soluction.Services
{
    public class Espresso : ICoffe
    {
        public string GetDescription() => "Espresso simple";

        public double GetCost() => 5.6;
    }
}
