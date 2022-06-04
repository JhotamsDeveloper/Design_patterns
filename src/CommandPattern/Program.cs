
using CommandPattern.Models;
using CommandPattern.Services;

/*
 * Crear una APP en donde
 * Al valor del producto se pueda crear un incremento
 * Al valor del producto se pueda crear un decremento
 * Validar a que el decremento no sea mayor al valor del producto
 * Registrar las transaciones
 * Revertir las transaciones
*/


ModifyPrice modifyPrice = new();
Product product = new Product("IPhone", 5000);

var increase = new ProductCommand(product, PriceAction.Increase, 100);
modifyPrice.SetCommand(increase);
modifyPrice.Invoke();

var decrease = new ProductCommand(product, PriceAction.Decrease, 35000);
//var decrease = new ProductCommand(product, PriceAction.Decrease, 3000);
modifyPrice.SetCommand(decrease);
modifyPrice.Invoke();

Console.WriteLine(product);
Console.WriteLine("UNDO ____________________________________________");

modifyPrice.Undo();
Console.WriteLine(product);

Console.ReadLine();