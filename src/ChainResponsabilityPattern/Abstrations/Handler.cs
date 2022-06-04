using ChainResponsabilityPattern.Interfaces;
using ChainResponsabilityPattern.Model;

namespace ChainResponsabilityPattern.Abstrations
{
    public abstract class Handler
    {
        protected Handler _successor;
        protected ISpecification<Mobile> _specification;

        protected Handler(ISpecification<Mobile> specification)
        {
            _specification = specification;
        }

        public void SetSuccessor(Handler successor)
        {
            this._successor = successor;
        }

        public abstract void HandleRequest(Mobile mobile);
    }
}
