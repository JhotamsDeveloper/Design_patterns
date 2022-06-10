using StatePatternOption3.Interfaces;

namespace StatePatternOption3.Services
{
    public class NewState : IState
    {
        public void Action(CustomerContext custumerContext, decimal amouont)
        {
            Console.WriteLine($"Se le pone dinero a su saldo {amouont}");
            custumerContext.Residue = amouont;
            custumerContext.SetState(new NotDebtorState());
        }
    }
}
