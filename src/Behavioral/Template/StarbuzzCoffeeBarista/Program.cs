namespace StarbuzzCoffeeBarista
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee = new Coffee();
            coffee.PrepareRecipe();
            Tea tea = new Tea();
            tea.PrepareRecipe();
        }
    }
}
