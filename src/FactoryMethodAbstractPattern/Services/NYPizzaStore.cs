using FactoryMethodAbstractPattern.Abstrations;
using FactoryMethodAbstractPattern.Helper;
using FactoryMethodAbstractPattern.Interfaces;


namespace FactoryMethodAbstractPattern.Services
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            string path = $"FactoryMethodAbstractPattern.Services.{Enum.GetName(typeof(TypeOfPizza), type)}Pizza";
            return (Pizza)Activator.
                 CreateInstance(Type.GetType(path),ingredientFactory);
        }

    }
}
