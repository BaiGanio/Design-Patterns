using System;
using SimUDuck.SwimBehavior;

namespace SimUDuck
{
    public class RubberDuck : IDuck
    {
        public RubberDuck(IFlyBehavior fb, IQuackBehavior qb) : base(fb, qb)
        {
        }

        public RubberDuck(IFlyBehavior fb, IQuackBehavior qb, ISwimBehavior sb) : base(fb, qb, sb)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Looks like rubber duck.");
        }
    }
}
