using System;

namespace PizzaLab
{
    public class SidneyPizzaStore : PizzaFactory
    {
        public override Pizza CreatePizza(PizzaType type)
        {
            return new PlovdivCheesePizza();
        }
    }
}
