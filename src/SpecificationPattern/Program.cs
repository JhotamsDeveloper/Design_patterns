using SpecificationPattern.Concrete;
using SpecificationPattern.Handler;
using SpecificationPattern.Interfaz;
using SpecificationPattern.Models;

List<Product> products = new()
{
    new Product("iPhone", 1000, "Electronics"),
    new Product("Chair", 50, "Furniture"),
    new Product("Shirt", 30, "Clothing"),
    new Product("TV", 800, "Electronics")
};

//Crear Especification
ISpecification<Product> electronicsSpec = new 
    CategorySpecification("Electronics");

ISpecification<Product> priceSpec = new 
    PriceSpecification(500);

//Filtrar los productos usando las especificaciones
List<Product> filterHandler = ProductFilterHandler
    .FilterBySpecification(products, electronicsSpec);

Console.WriteLine("Productos de la categoría 'Electronics':");
foreach (Product product in filterHandler)
{
    Console.WriteLine(product.Name);
}

filterHandler = ProductFilterHandler
    .FilterBySpecification(products, priceSpec);

Console.WriteLine("\nProductos con precio menor o igual a $500:");
foreach (Product product in filterHandler)
{
    Console.WriteLine(product.Name);
}