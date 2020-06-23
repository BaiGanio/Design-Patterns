using System;
using System.Linq;

namespace ShopOrders.ConcreteComponents
{
    class PreOrder : Order
    {
        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine("Calculating the total price of a preorder.");
            return products.Sum(x => x.Price) * 0.9;
        }
    }
}
