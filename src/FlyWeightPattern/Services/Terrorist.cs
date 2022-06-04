using FlyWeightPattern.Interfaces;

namespace FlyWeightPattern.Services
{
    public class Terrorist : IPlayer
    {
        private string _task;
        private string _weapon;

        public Terrorist() => _task = "colocar bomba";

        public void AssingWeapon(string weapon)
        {
            _weapon = weapon.ToUpper();
        }

        public void Mission()
        {
            Console.WriteLine($"El terrorista con el {_weapon} tiene la tarea de {_task}");
        }
    }
}
