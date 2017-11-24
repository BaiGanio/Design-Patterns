using Models.Interfaces;
using System;

namespace Models.Ducks
{
    public class RedheadDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Looks like redhead.");
        }

        public override void Fly()
        {
            Console.WriteLine("Looks like redhead duck is flying around.");
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
