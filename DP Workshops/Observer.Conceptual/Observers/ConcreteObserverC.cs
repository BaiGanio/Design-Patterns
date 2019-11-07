using System;

namespace Observer.Conceptual
{
    public class ConcreteObserverC : IObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine("ConcreteObserverC: Reacted to the all events.");
        }
    }
}
