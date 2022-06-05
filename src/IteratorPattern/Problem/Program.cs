using Problem.Services;

/*
 * Crear una APP que pueda
 * Crear un lista de desayunos y mostrarlos
 * Crear un array de cenas y mostrarlos
 * Realizar una iteración sobre los diferentes platos y mostrarlos en pantalla
*/

var breakFastMenu = new BreakfastMenuCollection();
var dinnerMenu = new DinnerMenuCollection();

foreach (var menu in breakFastMenu.GetMenuItems())
{
    Console.WriteLine(menu.Name);
    Console.WriteLine(menu.Description);
    Console.WriteLine(menu.Price);
    Console.WriteLine("_____________________________");
}
foreach (var menu in dinnerMenu.GetMenuItems())
{
    if (menu != null)
    {
        Console.WriteLine(menu.Name);
        Console.WriteLine(menu.Description);
        Console.WriteLine(menu.Price);
        Console.WriteLine("_____________________________");
    }
}

Console.ReadLine();