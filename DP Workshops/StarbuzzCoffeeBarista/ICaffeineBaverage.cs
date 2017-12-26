using System;
using System.Threading;

namespace StarbuzzCoffeeBarista
{
    public abstract class ICaffeineBaverage
    {
        public void PrepareRecipe()
        {
            Console.WriteLine("Start preparing the recipe....");
            Thread.Sleep(1000);
            BoilWater();
            Thread.Sleep(1000);
            Brew();
            Thread.Sleep(1000);
            PourInCup();
            Thread.Sleep(1000);
            if (CustomerWantsCondiments())
            {
                AddCondiments();
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Baverage {this.GetType().Name} done!");
            Console.WriteLine(new string('-', 30));
            Thread.Sleep(1000);
        }

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }

        public abstract void Brew();

        public abstract void AddCondiments();

        public void BoilWater()
        {
            Console.WriteLine("Boiling water.");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup.");
        }
    }
}
