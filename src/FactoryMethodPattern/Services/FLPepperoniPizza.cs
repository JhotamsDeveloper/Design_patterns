using FactoryMethodPattern.Abstractions;

namespace FactoryMethodPattern.Services
{
    public class FLPepperoniPizza : Pizza
    {
        public FLPepperoniPizza()
        {
            Name = "Pepperoni";
            Dough = "delgada";
            Sauce = "Salsa de tomates";
            Toppings.Add("Quesso mozarella");
        }
    }
}
