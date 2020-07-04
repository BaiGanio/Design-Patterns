namespace StarbuzzCoffee
{
    public class HouseBlend : IBaverage
    {
        readonly double _price = 0.89;
        readonly string _name = "House Blend Coffe";

        public override double Cost() => _price;
        public override string Name() => _name;
    }
}
