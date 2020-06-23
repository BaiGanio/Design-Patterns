using System;
using SimUDuck.SwimBehavior;

namespace SimUDuck
{
    public class MallardDuck : IDuck
    {
        public MallardDuck(IFlyBehavior fb, IQuackBehavior qb) : base(fb, qb)
        {
        }

        public MallardDuck(IFlyBehavior fb, IQuackBehavior qb, ISwimBehavior sb) : base(fb, qb, sb)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Looks like mallard.");
        }
    }
}
