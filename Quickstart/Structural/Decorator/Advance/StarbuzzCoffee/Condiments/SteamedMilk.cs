using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee
{
    public class SteamedMilk : ICondiment
    {
        readonly IBaverage _baverage;
        readonly double _price = 0.36;
        readonly string _name = "Steamed Milk";

        public SteamedMilk(IBaverage baverage)
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
