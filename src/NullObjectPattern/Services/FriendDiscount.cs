using NullObjectPattern.Interfaces;

namespace NullObjectPattern.Services
{
    public class FriendDiscount : IDiscount
    {
        public double CalculateDiscount(double productCost)
        {
            return productCost * 0.6;
        }
    }
}
