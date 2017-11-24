using System;

namespace SamUDuck
{
    public class MuteQuack : IQuackBehavior
    {
        public override void Quack()
        {
            Console.WriteLine("<<...Silence...>>");
        }
    }
}
