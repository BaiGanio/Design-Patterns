namespace SimUDuck.Ducks
{
    public class PaperDuck : IDuck
    {
        public PaperDuck(IFlyBehavior fb, IQuackBehavior qb) : base(fb, qb)
        {
        }

        public override void Display()
        {
            throw new System.NotImplementedException();
        }
    }
}
