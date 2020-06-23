using System;

namespace StarbuzzCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            IBaverage espresso = new Espresso();
            Console.WriteLine($"{espresso.Name()} = ${espresso.Cost()}");
            Console.WriteLine("------------------------------------------------------------------");
            IBaverage houseBlend = new HouseBlend();
            Console.WriteLine($"{houseBlend.Name()} = ${houseBlend.Cost()}");
            Console.WriteLine("------------------------------------------------------------------");
            IBaverage houseBlendWithMocha = new HouseBlend();
            houseBlendWithMocha = new Mocha(houseBlendWithMocha);
            Console.WriteLine($"{houseBlendWithMocha.Name()} = ${houseBlendWithMocha.Cost()}");
            Console.WriteLine("------------------------------------------------------------------");
            IBaverage darkRosatedWithMochaAndSteamedMilk = new DarkRoast();
            darkRosatedWithMochaAndSteamedMilk = new Mocha(darkRosatedWithMochaAndSteamedMilk);
            darkRosatedWithMochaAndSteamedMilk = new SteamedMilk(darkRosatedWithMochaAndSteamedMilk);
            Console.WriteLine($"{darkRosatedWithMochaAndSteamedMilk.Name()} = ${darkRosatedWithMochaAndSteamedMilk.Cost()}");
            Console.WriteLine("------------------------------------------------------------------");
        }
    }
}
