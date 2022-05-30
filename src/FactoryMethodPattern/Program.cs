using FactoryMethodPattern.Abstractions;
using FactoryMethodPattern.Helper;
using FactoryMethodPattern.Services;

/*
 * APLICACIÓN
 * 
 * Crear una aplicación para diferentes locales (NEW YORK, FLORIDA) que utilice el patrón Factory Method.
 * En donde se debe de crear una Pizza de acuerdo al local.
*/


PizzaStore pizzaStore = new NYPizzaStore();
Pizza pizza = pizzaStore.OrderPizza(TypeOfPizza.Pepperoni);

Console.WriteLine($"Pizza {pizza.Name} lista para ser entregada a JhotaMS");

pizzaStore = new FLPizzaStore();
pizza = pizzaStore.OrderPizza(TypeOfPizza.Neapolitan);
Console.WriteLine($"Pizza {pizza.Name} lista para ser entregada a Alexandra");

Console.ReadLine();