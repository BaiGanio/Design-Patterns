using System;

namespace SimUDuck
{
    public class Squeak : IQuackBehavior
    {
        public void QuackIt()
        {
            Console.WriteLine("Squeak");
        }
    }
}
