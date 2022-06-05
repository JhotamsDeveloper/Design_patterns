using MediatorPattern.Model;

namespace MediatorPattern.Interfaces
{
    public interface IMediator
    {
        void RegisterRunway(Runway runway);
        void RegisterFlight(Flight flight);
        bool IsLandingOk();
        void SetLandingStatus(bool status);

    }
}
