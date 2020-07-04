namespace PizzaLab
{
    public class MoscowPizzaStore : PizzaFactory
    {
        public override Pizza CreatePizza(PizzaType type)
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
                    return null;
                default:
                    return null;
            }
        }
    }
}
