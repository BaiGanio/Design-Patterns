using System;

namespace SimUDuck
{
    public class MallardDuck : IDuck
    {
        public MallardDuck(IFlyBehavior fb, IQuackBehavior qb) : base(fb, qb)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Looks like mallard.");
        }
    }
}
