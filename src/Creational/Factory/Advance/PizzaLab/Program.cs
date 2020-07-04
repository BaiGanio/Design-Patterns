using System;

namespace PizzaLab
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaFactory plovdivStore = new PlovdivPizzaStore();
            plovdivStore.OrderPizza(PizzaType.PlovdivCheese);
            Console.WriteLine("-----------------------");
            PizzaFactory moscowStore = new MoscowPizzaStore();
            moscowStore.OrderPizza(PizzaType.ChicagoPepperoni);
        }
    }
}
