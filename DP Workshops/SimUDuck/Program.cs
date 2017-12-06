using SimUDuck.Ducks;
using SimUDuck.FlyBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            IDuck[] ducks = new IDuck[]
            {
                new MallardDuck(new FlyWithWings(), new Quack()),
                new RedheadDuck(new FlyWithWings(), new Quack()),
                new RubberDuck(new FlyNoWay(), new Squeak()),
                new DecoyDuck(new FlyNoWay(), new MuteQuack()),
                /* Insert Iron and Papper ducks also. It will be fun */
                new ModelDuck(new FlyNoWay(), new MuteQuack())
            };

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.PerformQuack();
                duck.PerformFly();
                duck.Swim();
                Console.WriteLine(new string('-', 30));
                if (duck.GetType() == typeof(ModelDuck))
                {
                    Console.WriteLine("Dynamically set behavior to a object. Looks like model duck will fly at the end.");
                    duck.SetFlyBehavior(new FlyRockedPowered());
                    Console.Write($"{duck.GetType().Name} : ");
                    duck.PerformFly();
                    Console.WriteLine(new string('-', 30));
                }
            }
        }
    }
}
