using Newtonsoft.Json;
using System.Xml;

namespace AdapterPatternExemploTwo.Services;

internal class Apdater
{
    private static readonly string filePathData = "C:\\Users\\Jhonatan\\source\\repos\\CapacitacionSebas\\DesignPatternAdapter\\bin\\Debug\\net6.0\\datos_vehiculo.xml";
    private static readonly string filePath = "datos_vehiculo.json";
    public static void JsonFormat()
    {
        XmlDocument xmlDocument = new();
        xmlDocument.Load(filePathData);

        var dataJson = JsonConvert.SerializeXmlNode(xmlDocument);

        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }

        using StreamWriter writer = new(filePath);
        writer.Write(dataJson);
    }
}
