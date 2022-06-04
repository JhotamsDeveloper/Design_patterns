using ProxyMethodPattern.Interfaces;
using ProxyMethodPattern.Proxy;
using ProxyMethodPattern.Services;

ICar car = new CarProxy(new Driver(18, true));
car.Drive();

car = new CarProxy(new Driver(14, true));
car.Drive();

Console.ReadLine();
