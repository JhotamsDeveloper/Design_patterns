using NullObjectPattern.Interfaces;

namespace NullObjectPattern.Services
{
    public class StudentDiscount : IDiscount
    {
        public double CalculateDiscount(double productCost)
        {
            return productCost * 0.5;
        }
    }
}
