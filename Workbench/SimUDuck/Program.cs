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
                new DecoyDuck(new FlyNoWay(), new MuteQuack())
                /* Insert Iron and Papper ducks also. It will be fun */
            };

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.PerformQuack();
                duck.PerformFly();
                duck.Swim();
                Console.WriteLine(new string('-', 30));
            }
        }
    }
}
