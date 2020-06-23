namespace StarbuzzCoffee
{
    public class Mocha : ICondiment
    {
        readonly IBaverage _baverage;
        readonly double _price = 0.20;
        readonly string _name = "Mocha";

        public Mocha(IBaverage baverage)
        {
            _baverage = baverage;
        }

        public override double Cost()
        {
            return _baverage.Cost() + _price;
        }

        public override string Name()
        {
            return $"{_baverage.Name()} + {_name}";
        }
    }
}
