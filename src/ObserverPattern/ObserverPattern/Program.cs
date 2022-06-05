using ObserverPattern.Client;
using ObserverPattern.Products;

/*
 * Crear una APP en donde se le pueda
 * Notificar el precio a los clientes (Restaurantes) cuando este haya cambiado
 * Comprar productos de acuerdo al precio de compra de los clientes.
*/

Limon limon = new Limon(0.82);
limon.Attach(new Restaurant("La Paella", 0.77));
limon.Attach(new Restaurant("La Gloria", 0.74));
limon.Attach(new Restaurant("Los Consentidos", 0.75));

// Fluctuacion de precios
limon.PricePerKg = 0.79;
limon.PricePerKg = 0.76;
limon.PricePerKg = 0.74;
limon.PricePerKg = 0.81;

Console.ReadLine();