using System;

namespace PizzaLab
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizzaFactory plovdivStore = new PlovdivPizzaStore();
            plovdivStore.OrderPizza(PizzaType.PlovdivCheese);
            Console.WriteLine("-----------------------");
            IPizzaFactory moscowStore = new MoscowPizzaStore();
            moscowStore.OrderPizza(PizzaType.ChicagoPepperoni);
        }
    }
}
