using System;

namespace StarbuzzCoffeeBarista
{
    public class Tea : ICaffeineBaverage
    {        
        public override void Brew()
        {
            Console.WriteLine("Stepping the tea.");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding lemon.");
        }
    }
}
