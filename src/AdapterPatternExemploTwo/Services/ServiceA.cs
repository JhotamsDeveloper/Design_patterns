using AdapterPatternExemploTwo.Models;
using System.Xml;

namespace ServicesA;

public static class XmlExportDataExtensions
{

    private static readonly string filePath = "datos_vehiculo.xml";
    public static void XmlExportData(List<Vehicles> data)
    {
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }

        using XmlWriter writer = XmlWriter.Create(filePath);

        writer.WriteStartDocument();
        writer.WriteStartElement("datos_vehiculo");

        foreach (var item in data)
        {
            writer.WriteStartElement("item");
            writer.WriteElementString("Brand", item.Brand);
            writer.WriteElementString("Model", item.Model.ToString());
            writer.WriteElementString("CityOfCirculation", item.CityOfCirculation);
            writer.WriteEndElement();
        }

        writer.WriteEndElement();
        writer.WriteEndDocument();
        writer.Close();
    }
}
