namespace AdapterPattern.Model
{
    public class Product
    {
        public Product()
        { }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public int Price { get; set; }
    }
}
