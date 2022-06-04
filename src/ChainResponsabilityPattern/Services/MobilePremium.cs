using ChainResponsabilityPattern.Interfaces;
using ChainResponsabilityPattern.Model;

namespace ChainResponsabilityPattern.Services
{
    internal class MobilePremium : ISpecification<Mobile>
    {
        public bool IsSatified(Mobile item)
        {
            return item.Type == MobileRange.Premium;
        }
    }
}
