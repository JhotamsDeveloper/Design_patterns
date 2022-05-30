using FactoryMethodPattern.Abstractions;

namespace FactoryMethodPattern.Services
{
    public class NYCaliforniaPizza : Pizza
    {
        public NYCaliforniaPizza()
        {
            Name = "caifornia";
            Dough = "delgada";
            Sauce = "Salsa de tomates";
            Toppings.Add("Quesso mozarella");
        }
    }

}
