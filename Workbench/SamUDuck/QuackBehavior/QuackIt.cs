using System;

namespace SamUDuck
{
    public class QuackIt : IQuackBehavior
    {
        public override void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
