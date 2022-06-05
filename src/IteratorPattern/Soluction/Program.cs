using Soluction.Interfaces;
using Soluction.Model;
using Soluction.Servicios;

/*
 * Crear una APP que pueda
 * Crear un lista de desayunos y mostrarlos
 * Crear un array de cenas y mostrarlos
 * Realizar una iteración sobre los diferentes platos y mostrarlos en pantalla
*/

var breakFastMenu = new BreakfastMenuCollection();
var dinnerMenu = new DinnerMenuCollection();
IIterator<Menu> breakfastMenuIterator = breakFastMenu.CreateIterator();
IIterator<Menu> dinnerMenuIterator = dinnerMenu.CreateIterator();

Iterate(breakfastMenuIterator);
Iterate(dinnerMenuIterator);

Console.ReadLine();

static void Iterate(IIterator<Menu> iterator)
{
    while (iterator.HasNext())
    {
        Menu menu = iterator.Next();
        Console.WriteLine(menu.Name);
        Console.WriteLine(menu.Description);
        Console.WriteLine(menu.Price);
        Console.WriteLine("_____________________________");
    }
}