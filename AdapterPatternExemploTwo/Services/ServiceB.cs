namespace ServicesB;

public static class DataInJsonFormat
{
    private static readonly string filePath = @"C:\Users\Jhonatan\source\repos\CapacitacionSebas\DesignPatternAdapter\bin\Debug\net6.0\datos_vehiculo.json";
    public static string ReportVehicle()
    {
        if (!File.Exists(filePath))
        {
            throw new Exception("El archivo no existe");
        }
        return File.ReadAllText(filePath);
    }
}