using System;

namespace SimUDuck
{
    public class MuteQuack : IQuackBehavior
    {
        public void QuackIt()
        {
            Console.WriteLine("<<...Silence...>>");
        }
    }
}
