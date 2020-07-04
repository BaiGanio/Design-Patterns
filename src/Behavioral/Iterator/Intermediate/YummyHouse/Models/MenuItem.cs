namespace YummyHouse
{
    class MenuItem
    {
        private readonly string _name;
        private readonly string _description;
        private readonly bool _isVegeterian;
        private readonly double _price;

        public MenuItem(string name, string description, bool isVegeterian, double price)
        {
            _name = name;
            _description = description;
            _isVegeterian = isVegeterian;
            _price = price;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetDescription()
        {
            return _description;
        }

        public bool IsVegeterian()
        {
            return _isVegeterian;
        }

        public double GetPrice()
        {
            return _price;
        }
    }
}
