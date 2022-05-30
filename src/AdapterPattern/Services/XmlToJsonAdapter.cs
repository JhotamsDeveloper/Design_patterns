using AdapterPattern.Interfaces;
using AdapterPattern.Model;
using System.Xml.Linq;

namespace AdapterPattern.Services
{
    public class XmlToJsonAdapter : IXmlToJson
    {
        public void ConvertXmlToJson()
        {
            var products = GetXml()
                .Element("Productos")
                .Elements("Producto")
                .Select(m => new Product
                {
                    Name = m.Attribute("Nombre").Value,
                    Price = int.Parse(m.Attribute("Precio").Value)
                });

            new JsonConverter(products).ConvertToJson();
        }

        private XDocument GetXml()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Productos");
            var xAttributes = ProductDataProvider.GetData()
                .Select(m => new XElement("Producto",
                new XAttribute("Nombre", m.Name), new XAttribute("Precio", m.Price)));
            xElement.Add(xAttributes);
            xDocument.Add(xElement);
            return xDocument;
        }
    }
}
