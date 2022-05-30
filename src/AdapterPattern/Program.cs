using AdapterPattern.Interfaces;
using AdapterPattern.Services;


IXmlToJson adapter = new XmlToJsonAdapter();
adapter.ConvertXmlToJson();
Console.ReadLine();
