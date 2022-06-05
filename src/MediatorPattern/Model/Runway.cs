using MediatorPattern.Interfaces;

namespace MediatorPattern.Model
{
    public class Runway
    {
        private IMediator _mediator;

        public Runway(IMediator mediator)
        {
            _mediator = mediator;
            _mediator.SetLandingStatus(false);

        }

        public void Land()
        {
            Console.WriteLine("Permiso para aterrizar");
            _mediator.SetLandingStatus(true);
        }


    }
}
