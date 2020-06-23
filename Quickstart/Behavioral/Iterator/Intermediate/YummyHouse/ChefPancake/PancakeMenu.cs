using System.Collections.Generic;

namespace YummyHouse
{
    class PancakeMenu
    {
        // Chef Pancake uses List so he can extend his menu easier
        private readonly List<MenuItem> _menuItems;

        public PancakeMenu()
        {
            _menuItems = new List<MenuItem>();

            AddItem(
                "K&B's pancake breakfast",
                "Pancake with scrambled eggs and toast",
                true,
                2.99
            );

            var item2 = 
                new MenuItem(
                    "Regular pancake breakfast",
                    "Pancakes with fried eggs and sausage",
                    false,
                    2.99
                );

            var item3 =
                new MenuItem(
                    "Blueberry pancake",
                    "Pancakes with fresh blueberries",
                    true,
                    3.49
                );

            var item4 =
                new MenuItem(
                    "Waffles",
                    "Waffles with you choice of fresh blueberries or strawberries",
                    true,
                    3.59
                );

            _menuItems.AddRange(new List<MenuItem>() { item2, item3, item4 });

            var getLaidPancake =
                new MenuItem(
                    "Pancake to get laid",
                    "Pancake with sour cream, banana and strawberries",
                    true,
                    4.99
                );

            AddItem(getLaidPancake);
        }

        public List<MenuItem> GetMenuItems()
        {
            return _menuItems;
        }

        private void AddItem(MenuItem item)
        {
            _menuItems.Add(item);
        }

        private void AddItem(string name, string description, bool isVegeterian, double price)
        {
            var item = new MenuItem(name, description, isVegeterian, price);
            _menuItems.Add(item);
        }
    }
}
