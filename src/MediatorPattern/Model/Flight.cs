using MediatorPattern.Interfaces;

namespace MediatorPattern.Model
{
    public class Flight
    {
        private IMediator _mediator;

        public Flight(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Land()
        {
            if (_mediator.IsLandingOk())
            {
                Console.WriteLine("Se puede aterrizar");
                _mediator.SetLandingStatus(true);

            }
            else
            {
                Console.WriteLine("Esperando disponibilidad");
            }
        }
    }
}
