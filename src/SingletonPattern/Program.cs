using SingletonPattern.Interfaces;
using SingletonPattern.Services;

ISingletonContainer capitals = SingletonDataContainer.Instance;
ISingletonContainer capitals1 = SingletonDataContainer.Instance;
ISingletonContainer capitals3 = SingletonDataContainer.Instance;
Console.WriteLine($"Los habitantes de londres:  {capitals.GetPopulation("London")}");
Console.WriteLine($"Los habitantes de Washington, D.C.:  {capitals1.GetPopulation("Washington, D.C.")}");
Console.WriteLine($"Los habitantes de Beijing:  {capitals3.GetPopulation("Beijing")}");
Console.ReadLine();
