using BridgePattern.Services;

/*
 * Primer requerimiento
 * Crear una aplicativo que permita crear hacer el llamado al método Displey
 * 
 * Segundo requerimiento
 * Al metodo Displey crear la opción de reverse
*/


ReaderApp readerAppWin11 = new Win11(new NormalDisplay()) { Text = "Sistema operativo Win11 desde program.cs" };
readerAppWin11.Display();

ReaderApp readerAppIOS = new IOS(new NormalDisplay()) { Text = "Sistema operativo IOS desde program.cs" };
readerAppIOS.Display();

ReaderApp readerAppReverseWin11 = new Win11(new ReverserDisplay()) { Text = "Sistema operativo Win11 desde program.cs" };
readerAppReverseWin11.Display();

ReaderApp readerAppReverseIOS = new IOS(new ReverserDisplay()) { Text = "Sistema operativo IOS desde program.cs" };
readerAppReverseIOS.Display();