using WithIEnumerator.Model;
using WithIEnumerator.Servicios;


/*
 * Crear una APP que pueda
 * Crear un lista de desayunos y mostrarlos
 * Crear un array de cenas y mostrarlos
 * Realizar una iteración sobre los diferentes platos y mostrarlos en pantalla
*/



Iterate(new BreakfastMenuCollection());
Iterate(new DinnerMenuCollection());

Console.ReadLine();



static void Iterate(IEnumerator<Menu> iterator)
{
    while (iterator.MoveNext())
    {
        Menu menu = iterator.Current;
        Console.WriteLine(menu.Name);
        Console.WriteLine(menu.Description);
        Console.WriteLine(menu.Price);
        Console.WriteLine("_____________________________");
    }
}