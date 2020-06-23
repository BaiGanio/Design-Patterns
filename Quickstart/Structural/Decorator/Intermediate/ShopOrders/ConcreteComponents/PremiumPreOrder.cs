using System;

namespace ShopOrders.ConcreteComponents
{
    class PremiumPreOrder : OrderDecorator
    {
        public PremiumPreOrder(Order order)
            : base(order) { }

        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine($"Calculating the total price in the {nameof(PremiumPreOrder)} class.");
            var preOrderPrice = base.CalculateTotalOrderPrice();

            Console.WriteLine("Adding additional discount to a preorder price");
            return preOrderPrice * 0.9;
        }
    }
}
