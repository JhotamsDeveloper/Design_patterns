namespace ChainResponsabilityPattern.Model
{
    public class Mobile
    {
        public Mobile(MobileRange type, double price, string name)
        {
            Type = type;
            Price = price;
            Name = name;
        }

        public MobileRange Type { get; private set; }
        public double Price { get; private set; }
        public string Name { get; private set; }

        public override string ToString() => $"{Name}, Categoria: {Type}, Precio: {Price}";
    }

    public enum MobileRange
    {
        Basic,
        Medium,
        Premium
    }
}
