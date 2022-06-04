
using FlyWeightPattern.Interfaces;
using FlyWeightPattern.Services;

Factory factory = new();

for (int i = 0; i < 5; i++)
{
    IPlayer player = factory.GetPlayer(PlayerRandom.GetPlayerRandom());
    player.AssingWeapon(PlayerRandom.GetWeaponRandom());
    player.Mission();
}

Console.WriteLine(factory.GetNumberOfInstance().ToString());
Console.ReadLine();