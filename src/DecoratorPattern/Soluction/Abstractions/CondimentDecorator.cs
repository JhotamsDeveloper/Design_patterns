using Soluction.Interfaces;

namespace Soluction.Abstractions
{
    public class CondimentDecorator : ICoffe
    {
        private ICoffe _coffe;
        protected double _price = 0.0;
        protected string _name = string.Empty;

        public CondimentDecorator(ICoffe coffe)
        {
            _coffe = coffe;
        }

        public double GetCost() => _coffe.GetCost() + _price;

        public string GetDescription() => $"{_coffe.GetDescription()} {_name}";
    }
}
