using System;

namespace PizzaLab
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public virtual void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
        }

        public virtual void Bake()
        {
            Console.WriteLine($"Baking for 25 mins at 350 degrees");
        }

        public virtual void Cut()
        {
            Console.WriteLine($"Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine($"Placing pizza in official PizzaStore box");
        }
    }
}
