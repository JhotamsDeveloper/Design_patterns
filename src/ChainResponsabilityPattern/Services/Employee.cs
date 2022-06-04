using ChainResponsabilityPattern.Abstrations;
using ChainResponsabilityPattern.Interfaces;
using ChainResponsabilityPattern.Model;

namespace ChainResponsabilityPattern.Services
{
    public class Employee : Handler
    {
        public Employee(ISpecification<Mobile> specification) : base(specification)
        {
        }

        public override void HandleRequest(Mobile mobile)
        {
            if (CanHandle(mobile))
            {
                Console.WriteLine($"Order de {mobile} realizada por {this.GetType().Name}");
            }
            else
            {
                _successor.HandleRequest(mobile);
            }
        }

        public bool CanHandle(Mobile mobile)
        {
            return _specification.IsSatified(mobile);
        }
    }
}
