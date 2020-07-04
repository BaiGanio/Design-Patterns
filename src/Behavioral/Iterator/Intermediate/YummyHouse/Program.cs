namespace YummyHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //var yummyWaitress = new YummyWaitress(new PancakeMenu());
            var yummyWaitress = new YummyWaitress(new PancakeMenu(), new DinerMenu());
            yummyWaitress.PrintMenu();
        }
    }
}
