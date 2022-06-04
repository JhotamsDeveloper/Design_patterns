namespace FlyWeightPattern.Services
{
    public static class PlayerRandom
    {
        public static string[] playerType = { "Terrorist", "CounterTerrorist" };
        public static string[] weapons = { "bomba", "tnt", "ak47 de agua" };
        private static Random random = new();

        public static string GetPlayerRandom()
        {
            int index = random.Next(playerType.Length);
            return playerType[index];
        }
        public static string GetWeaponRandom()
        {
            int index = random.Next(weapons.Length);
            return weapons[index];
        }
    }
}
