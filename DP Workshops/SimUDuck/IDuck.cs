using System;
using SimUDuck.SwimBehavior;

namespace SimUDuck
{
    public abstract class IDuck
    {
        IFlyBehavior flyBehavior;
        IQuackBehavior quackBehavior;
        ISwimBehavior swimBehavior;

        public IDuck(IFlyBehavior fb, IQuackBehavior qb)
        {
            this.flyBehavior = fb;
            this.quackBehavior = qb;
        }

        public IDuck(IFlyBehavior fb, IQuackBehavior qb, ISwimBehavior sb) : this(fb, qb)
        {
            this.swimBehavior = sb;
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
            this.swimBehavior.Swim();
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

        internal void PerformFly(string v)
        {
            Console.WriteLine(v);
        }
    }
}
