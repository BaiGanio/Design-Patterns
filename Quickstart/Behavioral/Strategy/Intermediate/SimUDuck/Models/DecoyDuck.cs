using System;
using SimUDuck.SwimBehavior;

namespace SimUDuck
{
    public class DecoyDuck : IDuck
    {
        public DecoyDuck(IFlyBehavior fb, IQuackBehavior qb) : base(fb, qb)
        {
        }

        public DecoyDuck(IFlyBehavior fb, IQuackBehavior qb, ISwimBehavior sb) : base(fb, qb, sb)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Looks like decoy duck.");
        }
    }
}
