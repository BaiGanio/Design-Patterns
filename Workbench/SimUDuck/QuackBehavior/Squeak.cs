using System;

namespace SimUDuck
{
    public class Squeak : IQuackBehavior
    {
        public override void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
