using Soluction.Interfaces;

namespace Soluction.Services
{
    public class Filtered : ICoffe
    {
        public string GetDescription() => "Filtrado simple";
        public double GetCost() => 5.65;
    }
}
