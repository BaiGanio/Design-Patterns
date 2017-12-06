using System;
using SimUDuck.SwimBehavior;

namespace SimUDuck
{
    public class RedheadDuck : IDuck
    {
        public RedheadDuck(IFlyBehavior fb, IQuackBehavior qb) : base(fb, qb)
        {
        }

        public RedheadDuck(IFlyBehavior fb, IQuackBehavior qb, ISwimBehavior sb) : base(fb, qb, sb)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Looks like redhead.");
        }
    }
}
