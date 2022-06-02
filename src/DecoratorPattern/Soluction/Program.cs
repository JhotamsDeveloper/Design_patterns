using Soluction;
using Soluction.Services;

var espressoWithMilkAndChocolate = new MilkDecorator(new ChocolateDecorator(new Espresso()));
Console.WriteLine($"El precio de {espressoWithMilkAndChocolate.GetDescription()} {espressoWithMilkAndChocolate.GetCost()}");
Console.ReadLine();