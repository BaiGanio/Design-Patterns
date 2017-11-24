using System;

namespace SamUDuck
{
    public class RedheadDuck : IDuck
    {
        public RedheadDuck(IFlyBehavior fb, IQuackBehavior qb) : base(fb, qb)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Looks like redhead.");
        }
    }
}
