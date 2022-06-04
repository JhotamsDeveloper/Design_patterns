using FlyWeightPattern.Interfaces;

namespace FlyWeightPattern.Services
{
    public class CounterTerrorist : IPlayer
    {
        private string _task;
        private string _weapon;

        public CounterTerrorist() => _task = "desmontar bomba";

        public void AssingWeapon(string weapon)
        {
            _weapon = weapon.ToUpper();
        }

        public void Mission()
        {
            Console.WriteLine($"El anti terrorista con el {_weapon} tiene la tarea de {_task}");
        }
    }
}
