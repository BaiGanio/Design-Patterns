namespace StarbuzzCoffee
{
    public class DarkRoast : IBaverage
    {
        readonly double _price = 1.49;
        readonly string _name = "Dark Rost Coffee";

        public override double Cost() => _price;
        public override string Name() => _name;
    }
}
