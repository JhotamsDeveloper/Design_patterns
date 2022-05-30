using BuilderPattern.Builder;
using BuilderPattern.Concrete;
using BuilderPattern.Director;

List<double> toPay = new();

IFoodDishes assistantChef = new ConTypicalFood();
IDirector chefDirector = new ChefDirector(assistantChef);

toPay.Add(chefDirector.PrepareBandejaPaisa());
Console.WriteLine(assistantChef.GetTypicalDish().Result);

Console.WriteLine("__________________________________________________________");

toPay.Add(chefDirector.PrepareAjiaco());
Console.WriteLine(assistantChef.GetTypicalDish().Result);

Console.WriteLine($"Total to pay: {toPay.Sum()}");
