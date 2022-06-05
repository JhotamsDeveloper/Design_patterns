using MementoPattern.Model;
/*
 * Crear una APP para registrar transacciones donde
 * donde se pueda realizar un backup de las transacciones
*/
var account = new Account(100);
account.Deposit(20); // 120
account.Deposit(30); // 150
account.Deposit(40); // 190
account.Deposit(10); // 120

Console.WriteLine(account);
account.Undo();
Console.WriteLine($"Undo 1: {account}");
account.Undo();
Console.WriteLine($"Undo 2: {account}");
account.Redo();
Console.WriteLine($"Redo: {account}");

Console.ReadLine();