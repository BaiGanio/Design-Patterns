using System.Threading.Tasks;

namespace ChocolateFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler cb1 = new ChocolateBoiler();
            cb1.PrintDetails();
            ChocolateBoiler cb2 = new ChocolateBoiler();
            cb2.PrintDetails();
            cb1.PrintDetails();
            PrintWhiteChocolateDetails();
            PrintDarkChocolateDetails();
            Parallel.Invoke(
                () => PrintWhiteChocolateDetails(),
                () => PrintDarkChocolateDetails()
            );

        }

        private static void PrintWhiteChocolateDetails()
        {
            ChocolateBoiler fromWhiteChoco = new ChocolateBoiler();
            fromWhiteChoco.PrintDetails("I'm white chocolate!");
            fromWhiteChoco.PrintDetails();
        }

        private static void PrintDarkChocolateDetails()
        {
            ChocolateBoiler fromDarkChoco = new ChocolateBoiler();
            fromDarkChoco.PrintDetails("I'm dark chocolate!");
            fromDarkChoco.PrintDetails();
        }


    }
}
