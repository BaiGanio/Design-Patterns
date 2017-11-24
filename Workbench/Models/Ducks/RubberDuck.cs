using Models.Interfaces;
using System;

namespace Models.Ducks
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Looks like rubber duck.");
        }

        public override void Fly()
        {
            Console.WriteLine("Looks like rubber duck can't fly.");
        }

        public override void Quack()
        {
            Squeck();
        }

        public override void Swim()
        {
            throw new NotImplementedException();
        }

        #region Private methods

        private void Squeck()
        {
            Console.WriteLine("Quack");
        }

        #endregion

    }
}
