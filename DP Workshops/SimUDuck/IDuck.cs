using System;

namespace SimUDuck
{
    public abstract class IDuck
    {
        IFlyBehavior flyBehavior;
        IQuackBehavior quackBehavior;

        public IDuck(IFlyBehavior fb, IQuackBehavior qb)
        {
            this.flyBehavior = fb;
            this.quackBehavior = qb;
        }

        public virtual void PerformFly()
        {
            this.flyBehavior.Fly();
        }

        public virtual void PerformQuack()
        {
            this.quackBehavior.QuackIt();
        }

        public virtual void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public abstract void Display();

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            this.flyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            this.quackBehavior = qb;
        }
    }
}
