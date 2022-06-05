using NullObjectPattern.Interfaces;

namespace NullObjectPattern.Services
{
    public class Order
    {
        private IDiscount _discount;
        private int _productPrice;

        public Order(IDiscount discount, int productPrice)
        {
            _discount = discount;
            _productPrice = productPrice;
        }
        public Order() { }

        public double GetDiscout()
        {

            return _discount.CalculateDiscount(_productPrice);
        }

        public Order GetOrderByProducyName(string product) => new Order();
    }
}
