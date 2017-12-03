namespace SimUDuck.Ducks
{
    public class IronDuck : IDuck
    {
        public IronDuck(IFlyBehavior fb, IQuackBehavior qb) : base(fb, qb)
        {
        }

        public override void Display()
        {
            throw new System.NotImplementedException();
        }
    }
}
