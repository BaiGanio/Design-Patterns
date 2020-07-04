using System;
using System.Collections.Generic;
using System.Text;

namespace YummyHouse
{
    class DinerMenu
    {
        // Chef Diner use array so he can control the maximum size if his menu
        private const int MAX_ITEMS = 6;
        private int currentItems = 0;
        private readonly MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MAX_ITEMS];

            AddItem(
                "Vegeterian BLT",
                "(Fakin') Bacon with lattuce & tomatto on whole wheat",
                true,
                4.99
            );

            var item2 = 
                new MenuItem(
                    "BLT",
                    "Bacon with lettuce & tomatto on whole wheat",
                    false,
                    5.99
                );

            AddItem(item2);

            AddItem(
                "The Soup",
                "Soup with a side of potato salad",
                false,
                2.45
            );

            AddItem(
                "Veggie Hotdog",
                "Onion & lettuce topped with cheese",
                true,
                3.77
            );
        }

        private void AddItem(MenuItem item)
        {
            if (currentItems >= MAX_ITEMS) //menu is full
                throw new Exception("Sorry, menu is full! Can't add more items.");
            else
            {
                _menuItems[currentItems] = item;
                currentItems++;
            }
        }

        private void AddItem(string name, string description, bool isVegeterian, double price)
        {
            var item = new MenuItem(name, description, isVegeterian, price);
            if (currentItems >=  MAX_ITEMS) //menu is full
            {
                throw new Exception("Sorry, menu is full! Can't add more items.");
            }
            else
            {
                _menuItems[currentItems] = item;
                currentItems++;
            }
        }

        public MenuItem[] GetMenuItems()
        {
            return _menuItems;
        }
    }
}
