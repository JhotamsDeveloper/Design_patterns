using Soluction.Services;

HomeController homeController = new HomeController();

Console.WriteLine("Llegando a casa....");
homeController.TurnOn();
Console.WriteLine("Salir de casa....");
homeController.TurnOff();
Console.ReadLine();
