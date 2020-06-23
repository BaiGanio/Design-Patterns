using System;

namespace YummyHouse
{
    class YummyWaitress
    {
        private readonly PancakeMenu _pancakeMenu;
        private readonly DinerMenu _dinerMenu;
        public YummyWaitress(PancakeMenu pancakeMenu)
        {
            _pancakeMenu = pancakeMenu;
        }

        public YummyWaitress(DinerMenu dinerMenu)
        {
            _dinerMenu = dinerMenu;
        }

        public YummyWaitress(PancakeMenu pancakeMenu, DinerMenu dinerMenu)
        {
            _pancakeMenu = pancakeMenu;
            _dinerMenu = dinerMenu;
        }


        // 1. Print every item on the menu
        internal void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("| YUMMY HOUSE MENU |");
            Console.WriteLine(new string('-', 20));
            Console.WriteLine();

            PrintBreakfastMenu();
            Console.WriteLine();
            PrintDinerMenu();
        }

        // 2. Print breakfast menu
        internal void PrintBreakfastMenu()
        {
            Console.WriteLine(new string('-', 26));
            Console.WriteLine("| CHEF PANCAKE BREAKFAST |");
            Console.WriteLine(new string('-', 26));
            Console.WriteLine();

            var menuItems = _pancakeMenu.GetMenuItems();

            foreach (var item in menuItems)
            {
                Console.WriteLine($"{item.GetName()}, ${item.GetPrice()} -- {item.GetDescription()}");
            }

            Console.WriteLine(new string('-', 40));
        }


        // 3. Print lunch menu
        internal void PrintDinerMenu()
        {
            Console.WriteLine(new string('-', 19));
            Console.WriteLine("| CHEF DINER MENU |");
            Console.WriteLine(new string('-', 19));
            Console.WriteLine();

            var menuItems = _dinerMenu.GetMenuItems();

            for (int i = 0; i < menuItems.Length; i++)
            {
                if (menuItems[i] == null) 
                    break;

                Console.WriteLine($"{menuItems[i].GetName()}, ${menuItems[i].GetPrice()} -- {menuItems[i].GetDescription()}");
            }

            Console.WriteLine(new string('-', 40));
        }

        // 4. Print vegeterian menu items

        // 5. Check if menu item is vegeterian by name
    }
}
