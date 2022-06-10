using StatePatternOption3.Services;

namespace StatePatternOption3.Interfaces
{
    public interface IState
    {
        public void Action(CustomerContext custumerContext, decimal amouont);
    }
}
