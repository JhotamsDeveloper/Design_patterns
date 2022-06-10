using StatePatternOption3.Interfaces;

namespace StatePatternOption3.Services
{
    public class DebtorState : IState
    {
        public void Action(CustomerContext custumerContext, decimal amouont)
        {
            Console.WriteLine($"No puedes comprar porque eres un deudor");
        }
    }
}
