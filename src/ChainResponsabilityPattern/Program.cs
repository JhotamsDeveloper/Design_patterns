
using ChainResponsabilityPattern.Model;
using ChainResponsabilityPattern.Services;

/*
 * Crear una APP en donde el 
 * CEO pueda vender equipo de gama alta
 * Supervisor pueda vender equipo de gama media
 * Empleado pueda vender equipo de gama baja
*/

Mobile iphone = new Mobile(MobileRange.Premium, 1500, "IPhone 14");
Mobile xiaomiMI = new Mobile(MobileRange.Medium, 300, "Xiaomi M9");
Mobile xiaomiRedmi = new Mobile(MobileRange.Basic, 800, "Xiaomi redmi");

var phones = new List<Mobile>();
phones.Add(xiaomiMI);
phones.Add(xiaomiRedmi);
phones.Add(iphone);

Employee employee = new Employee(new MobileBasic());
Supervisor supervisor = new Supervisor(new MobileMedium());
CEO ceo = new CEO(new MobilePremium());

employee.SetSuccessor(supervisor);
supervisor.SetSuccessor(ceo);

phones.ForEach(phone => employee.HandleRequest(phone));
Console.ReadLine();
