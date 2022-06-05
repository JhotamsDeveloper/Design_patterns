using NullObjectPattern.Services;
/*
 * Crear una APP en donde algunos productos se pueda
 * Crear un descuento de acuerdo al perfil del comprador y que
 * tambien a algunas ventas no se le pueda general descuento
*/

var studentOrder = new Order(new StudentDiscount(), 50);
studentOrder.GetDiscout();

var friendOrder = new Order(new FriendDiscount(), 100);
friendOrder.GetDiscout();

var noDiscountOrder = new Order(new NullDiscount(), 250);
noDiscountOrder.GetDiscout();

var order = new Order();
order.GetOrderByProducyName("Producto");

Console.ReadKey();
