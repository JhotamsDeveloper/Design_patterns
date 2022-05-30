using FactoryMethodPattern.Abstractions;

namespace FactoryMethodPattern.Services
{
    public class FLCaliforniaPizza : Pizza
    {
        public FLCaliforniaPizza()
        {
            Name = "caifornia";
            Dough = "delgada";
            Sauce = "Salsa de tomates";
            Toppings.Add("Quesso mozarella");
        }
    }
}
