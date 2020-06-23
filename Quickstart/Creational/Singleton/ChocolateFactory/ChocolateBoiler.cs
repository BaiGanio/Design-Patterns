using System;

namespace ChocolateFactory
{
    public sealed class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        private static int counter = 0;

        public ChocolateBoiler()
        {
            this.empty = true;
            this.boiled = false;
            counter++;
        }

        /* 
         * Public method which can be invoked through singleton instance 
         */
        public void PrintDetails()
        {
            Console.WriteLine($"Counter value for created instances: {counter}");
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine($"{message}");
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                this.empty = false;
                this.boiled = false;
                // TODO: Fill the boiler with a milk/chocolate mixture
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                this.empty = true;
                // TODO: Drain the boiled milk and chocolate mixture
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                // TODO: Boil the milk/chocolate mixture
                this.boiled = true;
            }
        }

        public bool IsEmpty()
        {
            return this.empty;
        }

        public bool IsBoiled()
        {
            return this.boiled;
        }

    }
}
