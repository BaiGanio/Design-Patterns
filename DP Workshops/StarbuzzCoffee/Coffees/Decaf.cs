namespace StarbuzzCoffee
{
    public class Decaf : IBaverage
    {
        readonly double _price = 1.59;
        readonly string _name = "Decaf";

        public override double Cost() => _price;
        public override string Name() => _name;
    }
}
