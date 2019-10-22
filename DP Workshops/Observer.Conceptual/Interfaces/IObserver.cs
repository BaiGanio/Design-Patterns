using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Conceptual
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
    }
}
