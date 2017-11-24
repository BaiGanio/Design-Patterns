using System;

namespace SamUDuck
{
    public class Squeak : IQuackBehavior
    {
        public override void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
