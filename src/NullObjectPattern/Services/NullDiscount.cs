using NullObjectPattern.Interfaces;

namespace NullObjectPattern.Services
{
    public class NullDiscount : IDiscount
    {
        public double CalculateDiscount(double productCost)
        {
            return 0;
        }
    }
}
