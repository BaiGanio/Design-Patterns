using System;

namespace PizzaLab
{
    public class SidneyPizzaStore : IPizzaFactory
    {
        public override IPizza CreatePizza(PizzaType type)
        {
            return new PlovdivCheesePizza();
        }
    }
}
