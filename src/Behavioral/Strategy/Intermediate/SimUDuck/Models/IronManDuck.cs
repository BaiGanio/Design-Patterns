using SimUDuck.SwimBehavior;

namespace SimUDuck
{
    public class IronManDuck : IDuck
    {
        public IronManDuck(IFlyBehavior fb, IQuackBehavior qb, ISwimBehavior swimBehavior ) : base(fb, qb, swimBehavior)
        {
        }

        public override void Display()
        {
            System.Console.WriteLine("This iron duck looks like ROBODUCK!");
        }
    }
}