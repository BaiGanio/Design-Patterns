using System;

namespace SimUDuck
{
    public class MuteQuack : IQuackBehavior
    {
        public override void Quack()
        {
            Console.WriteLine("<<...Silence...>>");
        }
    }
}
