namespace StarbuzzCoffee
{
    public abstract class IBaverage
    {
        readonly string _description = "Unknown Baverage";

        public virtual string Name()
        {
            return _description;
        }
        public abstract double Cost();
    }
}
