namespace PizzaLab
{
    public abstract class IPizzaFactory
    {
        public IPizza OrderPizza(PizzaType type)
        {
            IPizza pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        public abstract IPizza CreatePizza(PizzaType type);
    }
}
