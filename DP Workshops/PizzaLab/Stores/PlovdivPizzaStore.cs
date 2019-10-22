using System;

namespace PizzaLab
{
    public class PlovdivPizzaStore : IPizzaFactory
    {
        public override IPizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.ChicagoPepperoni:
                    return new ChicagoPepperoniPizza();
                case PizzaType.NYClam:
                    return null;
                case PizzaType.PlovdivCheese:
                    return new PlovdivCheesePizza();
                case PizzaType.TokyoVeggie:
                    return null; ;
                default:
                    return null;
            }
        }
    }
}
