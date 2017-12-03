using System;

namespace SimUDuck
{
    public class Quack : IQuackBehavior
    {
        public void QuackIt()
        {
            Console.WriteLine("Quack");
        }
    }
}
