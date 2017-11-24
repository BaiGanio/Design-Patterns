using Models.Interfaces;
using System;

namespace Models.Ducks
{
    public class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Looks like mallard.");
        }

        public override void Fly()
        {
            Console.WriteLine("Looks like mallard duck is flying around.");
        }

        public override void Quack()
        {
            Console.WriteLine("Quack");
        }

        public override void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
