using Problem.Services;

LightController light = new LightController();
WifiController wifi = new WifiController();
AirConditionerController air = new AirConditionerController();

Console.WriteLine("Llegando a casa....");
light.TurnOn();
wifi.TurnOn();
air.TurnOn();

Console.WriteLine("Salir de casa....");
air.TurnOff();
wifi.TurnOff();
light.TurnOff();

Console.ReadLine();