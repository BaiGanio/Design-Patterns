using System;

namespace SamUDuck
{
    class Startup
    {
        static void Main(string[] args)
        {
            IDuck[] ducks = new IDuck[]
            {
                new MallardDuck(new FlyWithWings(), new QuackIt()),
                new RedheadDuck(new FlyWithWings(), new QuackIt()),
                new RubberDuck(new FlyNoWay(), new Squeak()),
                new DecoyDuck(new FlyNoWay(), new MuteQuack())
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
