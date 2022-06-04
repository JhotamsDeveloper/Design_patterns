using ProxyMethodPattern.Interfaces;
using ProxyMethodPattern.Services;

namespace ProxyMethodPattern.Proxy
{
    public class CarProxy : ICar
    {
        private Car _car = new();
        private Driver _drive;

        public CarProxy(Driver drive)
        {
            _drive = drive;
        }

        public void Drive()
        {
            if (_drive.CanDrive())
            {
                _car.Drive();
            }
            else
            {
                Console.WriteLine("El conductor no puede conducir");
            }
        }
    }
}
