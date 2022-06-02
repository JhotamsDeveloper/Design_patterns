using Soluction.Abstractions;
using Soluction.Interfaces;

namespace Soluction
{
    public class ChocolateDecorator : CondimentDecorator
    {
        public ChocolateDecorator(ICoffe coffe) : base(coffe)
        {
            _name = "Chocolate";
            _price = 0.45;
        }
    }
}
