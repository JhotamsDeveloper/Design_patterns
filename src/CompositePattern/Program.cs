using CompositePattern.Abstrations;
using CompositePattern.Services;

/*
 * Aplicación
 * Crear una aplicación para una tiendad de tecnología en donde se puede vender accesorios indivuduales o kit's para
 * emsamblar computadores en la tienda.
*/


Product ram = new SimpleProduct("Ram 16 gb", 7000);
Product processor = new SimpleProduct("Intel core 7", 17000);
Product videoCard = new SimpleProduct("nVidia gtx 1050", 85000);
Product keyBoard = new SimpleProduct("Teclado Dell", 300);
Product mouse = new SimpleProduct("Mouse Dell", 300);
Product rig = new SimpleProduct("Torre hp", 3000);
Product led = new SimpleProduct("Led Lg", 4000);

Product gamingKit = new CompositeProduct("Computador gamer básico");
gamingKit.Add(ram);
gamingKit.Add(processor);
gamingKit.Add(videoCard);
gamingKit.Add(keyBoard);
gamingKit.Add(mouse);
gamingKit.Add(rig);
gamingKit.Add(led);

Console.WriteLine(gamingKit.GetPrice());
Console.ReadLine();