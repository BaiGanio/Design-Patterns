namespace StarbuzzCoffee
{
    public class Espresso : IBaverage
    {
        readonly double _price = 1.99;
        readonly string _name = "Espresso";

        public override double Cost() => _price;
        public override string Name() => _name;
    }
}
