using ChainResponsabilityPattern.Interfaces;
using ChainResponsabilityPattern.Model;

namespace ChainResponsabilityPattern.Services
{
    public class MobileMedium : ISpecification<Mobile>
    {
        public bool IsSatified(Mobile item)
        {
            return item.Type == MobileRange.Medium;
        }
    }
}
