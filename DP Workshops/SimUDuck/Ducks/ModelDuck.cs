using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck.Ducks
{
    public class ModelDuck : IDuck
    {
        public ModelDuck(IFlyBehavior fb, IQuackBehavior qb) : base(fb, qb)
        {
            
        }

        public override void Display()
        {
            Console.WriteLine("Looks like model.");
        }
    }
}
