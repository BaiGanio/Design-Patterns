using SimUDuck.Ducks;
using SimUDuck.FlyBehavior;
using SimUDuck.SwimBehavior;
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
            Console.OutputEncoding = Encoding.UTF8;
            IDuck[] ducks = new IDuck[]
            {
                new MallardDuck(new FlyWithWings(), new Quack(), new SwimLikeTree()),
                new RedheadDuck(new FlyWithWings(), new Quack(), new SwimLikeTree()),
                new RubberDuck(new FlyNoWay(), new Squeak(), new SwimLikeTree()),
                new DecoyDuck(new FlyNoWay(), new MuteQuack(), new SwimLikeTree()),
                new ModelDuck(new FlyNoWay(), new MuteQuack(), new SwimLikeStoneSinking()),
                new IronManDuck(new FlyNoWay(), new MuteQuack(), new SwimLikeStoneSinking())
            };

            foreach (var duck in ducks)
            {
                switch (duck.GetType().Name.ToString())
                {
                    case "ModelDuck":
                        DoState(duck);
                        DoMallardDuckNewState(duck);
                        break;
                    case "IronManDuck":
                        DoState(duck);
                        DoIronManDuckNewState(duck);
                        break;
                    default:
                        DoState(duck);                       
                        break;
                }                
                Console.WriteLine(new string('-', 30));
            }
        }

        private static void DoIronManDuckNewState(IDuck duck)
        {
            Console.WriteLine("At the end, the rocket jet pack on the back of the IRONDUCK starts up..");
            duck.SetFlyBehavior(new FlyRockedPowered());
            Console.Write($"{duck.GetType().Name} : ");
            duck.PerformFly("Гааа-аа--аа--ззз-зз.....");
        }

        private static void DoMallardDuckNewState(IDuck duck)
        {
            Console.WriteLine("Dynamically set behavior to a object. Looks like model duck will fly at the end.");
            duck.SetFlyBehavior(new FlyRockedPowered());
            Console.Write($"{duck.GetType().Name} : ");
            duck.PerformFly();
        }

        private static void DoState(IDuck duck)
        {
            duck.Display();
            duck.PerformQuack();
            duck.PerformFly();
            duck.Swim();
        }
    }
}
