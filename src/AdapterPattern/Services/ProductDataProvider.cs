using AdapterPattern.Model;

namespace AdapterPattern.Services
{
    public static class ProductDataProvider
    {
        public static List<Product> GetData() =>
            new()
            {
                new Product("IPhone", 5000),
                new Product("Xiaomi Mi 2", 100),
                new Product("Samsung s9", 4000)
            };
    }
}
