using ChainResponsabilityPattern.Interfaces;
using ChainResponsabilityPattern.Model;

namespace ChainResponsabilityPattern.Services
{
    public class MobileBasic : ISpecification<Mobile>
    {
        public bool IsSatified(Mobile item)
        {
            return item.Type == MobileRange.Basic;
        }
    }
}
