using StatePatternOption3.Interfaces;

namespace StatePatternOption3.Services
{
    public class NotDebtorState : IState
    {
        public void Action(CustomerContext custumerContext, decimal amouont)
        {
            if (amouont <= custumerContext.Residue)
            {
                custumerContext.Descount(amouont);
                Console.WriteLine($"Solicitud permitida, gasta {amouont} y le queda de salgo {custumerContext.Residue}");
                custumerContext.SetState(new NotDebtorState());

                if (custumerContext.Residue <= 0)
                {
                    custumerContext.SetState(new DebtorState());
                }
            }
            else
            {
                Console.WriteLine($"No ajustas lo solicitado, ya que tienes {custumerContext.Residue} y quieres gastar {amouont}");
            }

        }
    }
}
