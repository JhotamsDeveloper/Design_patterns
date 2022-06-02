using Soluction.Abstractions;
using Soluction.Interfaces;

namespace Soluction
{
    public class MilkDecorator : CondimentDecorator
    {
        public MilkDecorator(ICoffe coffe) : base(coffe)
        {
            _name = "Leche";
            _price = 0.25;
        }
    }
}
