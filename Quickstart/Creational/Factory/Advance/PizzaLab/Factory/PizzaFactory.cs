namespace PizzaLab
{
    public abstract class PizzaFactory
    {
        public Pizza OrderPizza(PizzaType type)
        {
            Pizza pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        public abstract Pizza CreatePizza(PizzaType type);
    }
}
