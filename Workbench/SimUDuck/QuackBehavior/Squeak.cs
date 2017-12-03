using System;

namespace SimUDuck
{
    public class Squeak : IQuackBehavior
    {
        public override void QuackIt()
        {
            Console.WriteLine("Squeak");
        }
    }
}
