using FactoryMethodPattern.Abstractions;

namespace FactoryMethodPattern.Services
{
    public class NYNeapolitanPizza : Pizza
    {
        public NYNeapolitanPizza()
        {
            Name = "Napolitana";
            Dough = "delgada";
            Sauce = "Salsa de tomates";
            Toppings.Add("Quesso mozarella");
        }
    }
}
