using System;

namespace ShopOrders
{
    class OrderDecorator : Order
    {
        protected Order _order;

        public OrderDecorator(Order order) => _order = order;

        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine($"Calculating the total price in a decorator class");
            return _order.CalculateTotalOrderPrice();
        }
    }
}
