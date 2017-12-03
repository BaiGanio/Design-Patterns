using System;

namespace SimUDuck
{
    public class Quack : IQuackBehavior
    {
        public override void QuackIt()
        {
            Console.WriteLine("Quack");
        }
    }
}
