
using Problem.Services;

Espresso espresso = new Espresso(true, true);
Console.WriteLine($"El precio de un expreso {espresso.GetCost()}");
Console.ReadLine();