using CommandPattern.Interfaces;
using CommandPattern.Models;

namespace CommandPattern.Services
{
    public class ProductCommand : IProductCommand
    {
        private Product _product;
        private PriceAction _priceAction;
        private int _amount;

        public bool IsCommandExe { get; private set; }
        public ProductCommand(Product product, PriceAction priceAction, int amount)
        {
            _product = product;
            _priceAction = priceAction;
            _amount = amount;
        }

        public void Execute()
        {
            if (_priceAction == PriceAction.Increase)
            {
                _product.IncreasePrice(_amount);
                IsCommandExe = true;
            }
            else
            {
                IsCommandExe = _product.DecreasePrice(_amount);
            }
        }

        public void Undo()
        {
            if (!IsCommandExe)
            {
                return;
            }

            if (_priceAction == PriceAction.Increase)
            {
                _product.DecreasePrice(_amount);
            }
            else
            {
                _product.IncreasePrice(_amount);
            }
        }
    }
}
