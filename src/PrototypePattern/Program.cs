
using PrototypePattern.Helpers;
using PrototypePattern.Models;

Product notebook = new Product("MacBook Pro", new Category("Computers"));

Product dell = notebook.DeepCopy();
dell.Category.Name = "Notebooks";
dell.Name = "Dell";

Product asus = notebook.DeepCopy();
asus.Category.Name = "Ultra";
asus.Name = "Asus";

Console.WriteLine(notebook);
Console.WriteLine(dell);
Console.WriteLine(asus);

Console.ReadLine();
