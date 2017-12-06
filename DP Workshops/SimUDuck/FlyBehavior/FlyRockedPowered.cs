using System;

namespace SimUDuck.FlyBehavior
{
    public class FlyRockedPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
