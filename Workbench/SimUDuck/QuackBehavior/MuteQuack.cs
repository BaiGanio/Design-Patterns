using System;

namespace SimUDuck
{
    public class MuteQuack : IQuackBehavior
    {
        public override void QuackIt()
        {
            Console.WriteLine("<<...Silence...>>");
        }
    }
}
