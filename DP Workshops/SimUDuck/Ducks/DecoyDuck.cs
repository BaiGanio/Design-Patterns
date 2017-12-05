using System;

namespace SimUDuck
{
    public class DecoyDuck : IDuck
    {
        public DecoyDuck(IFlyBehavior fb, IQuackBehavior qb) : base(fb, qb)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Looks like decoy duck.");
        }
    }
}
