namespace Soluction.Model
{
    public class Menu
    {
        public Menu(string name, string description, double price, bool isVegatarian)
        {
            Name = name;
            Description = description;
            Price = price;
            IsVegatarian = isVegatarian;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Price { get; private set; }
        public bool IsVegatarian { get; private set; }
    }
}
