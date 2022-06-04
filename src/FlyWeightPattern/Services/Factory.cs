using FlyWeightPattern.Interfaces;

namespace FlyWeightPattern.Services
{
    public class Factory
    {
        Dictionary<string, IPlayer> _player = new();
        public int GetNumberOfInstance() => _player.Count;

        public IPlayer GetPlayer(string key)
        {
            IPlayer player = null;

            if (_player.ContainsKey(key))
            {
                player = _player[key];
            }
            else
            {
                switch (key)
                {
                    case "Terrorist":
                        player = new Terrorist();
                        break;
                    case "CounterTerrorist":
                        player = new CounterTerrorist();
                        break;
                }

                _player.Add(key, player);
            }

            return player;
        }
    }
}
