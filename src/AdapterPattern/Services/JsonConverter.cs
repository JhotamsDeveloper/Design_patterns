using AdapterPattern.Model;
using System.Text.Json;

namespace AdapterPattern.Services
{
    public class JsonConverter
    {
        private IEnumerable<Product> _productData;

        public JsonConverter(IEnumerable<Product> productData)
        {
            _productData = productData;
        }

        public void ConvertToJson()
        {
            var result = JsonSerializer.Serialize(_productData);
            Console.WriteLine(result);
        }
    }
}
