using System;

namespace StarbuzzCoffeeBarista
{
    public class Coffee : ICaffeineBaverage
    {
        private const string _milk = "milk";
        private const string _sugar = "sugar";
        public override void Brew()
        {
            Console.WriteLine("Dripping coffee trough filter.");
        }

        public override void AddCondiments()
        {
            Console.WriteLine($"Adding {_sugar} & {_milk}.");
        }

        public override bool CustomerWantsCondiments()
        {
            string answer = GetUserInput();
            if (answer.ToLower() != "yes")
            {
                return false;
            }
            return true;
        }

        private string GetUserInput()
        {
            char answer = ' ';
            Console.Write($"Would you like {_sugar} & {_milk} with your coffee? (y/n)?");
            try
            {
                answer = char.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"IO error trying to read your input. Exception message: {ex.Message}");
            }
            if (answer != 'y')
            {
                return "no";
            }
            return "yes";
        }
    }
}
