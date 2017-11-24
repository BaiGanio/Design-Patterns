using System;

namespace SamUDuck
{
    public class RubberDuck : IDuck
    {
        public RubberDuck(IFlyBehavior fb, IQuackBehavior qb) : base(fb, qb)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Looks like rubber duck.");
        }
    }
}
