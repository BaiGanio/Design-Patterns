using System;

namespace SimUDuck
{
    public class QuackIt : IQuackBehavior
    {
        public override void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
