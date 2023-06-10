using AdapterPatternExemploTwo.Common;
using AdapterPatternExemploTwo.Services;

using ServicesA;
using ServicesB;

Console.WriteLine("Se crea el listado de vehiculo");
Console.WriteLine("");
Console.WriteLine("El servicio A se activa");
Console.WriteLine("");
XmlExportDataExtensions
    .XmlExportData(ListDataVehicle.GetVehicles());

Console.WriteLine("");
Console.WriteLine("Se exporta los datos");
Console.WriteLine("");

Console.WriteLine("Adaptador");
Console.WriteLine("");
Console.WriteLine("El adaptador entra y convierta la data de un archivo xml en json");
Console.WriteLine("");

Apdater.JsonFormat();
Console.WriteLine("Se exporta los datos en formato JSON.");

Console.WriteLine("");
Console.WriteLine("El servicio b se activa");

Console.WriteLine("");
var json = DataInJsonFormat.ReportVehicle();
Console.WriteLine(json);