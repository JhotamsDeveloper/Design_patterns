namespace CommandPattern.Models
{
    public class Product
    {
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public int Price { get; set; }

        public void IncreasePrice(int amount)
        {
            Price += amount;
            Console.WriteLine($"El precio de {Name} se incremento por {amount}");
        }

        public bool DecreasePrice(int amount)
        {
            if (amount < Price)
            {
                Price -= amount;
                Console.WriteLine($"El precio de {Name} se decremento por {amount}");
                return true;
            }

            return false;
        }

        public override string ToString() => $"El precio actual de {Name} es {Price}";

    }

    public enum PriceAction
    {
        Increase,
        Decrease
    }
}
