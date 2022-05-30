﻿using FactoryMethodPattern.Abstractions;
using FactoryMethodPattern.Helper;

namespace FactoryMethodPattern.Services
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            //switch (name)
            //{
            //    case "pepperoni":
            //        return new NYPepperoniPizza();
            //    case "Neapolitan":
            //        return new NYNeapolitanPizza();
            //    case "California":
            //        return new NYCaliforniaPizza();
            //    default:
            //        return null;

            //}

            return (Pizza)Activator.
                CreateInstance(Type.GetType($"FactoryMethodPattern.Services.NY{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"));
        }
    }
}
