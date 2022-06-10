using StatePatternOption3.Services;

CustomerContext customerContext = new CustomerContext();
Console.WriteLine(customerContext.GetState());
customerContext.Request(100);
Console.WriteLine(customerContext.GetState());
customerContext.Request(50);
Console.WriteLine(customerContext.GetState());
customerContext.Request(100);
Console.WriteLine(customerContext.GetState());
customerContext.Request(50);
Console.WriteLine(customerContext.GetState());
Console.ReadLine();