using System;

namespace PizzaLab
{
    public class ChicagoPepperoniPizza : Pizza
    {
        public ChicagoPepperoniPizza()
        {
            Name = "Chicago Style deep Dish Pepperoni Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";
        }

        public override void Bake()
        {
            Console.WriteLine($"Baking for 17 mins at 315 degrees");
        }
        public override void Cut()
        {
            Console.WriteLine($"Cutting the pizza into square slices");
        }
    }
}
