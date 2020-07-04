using System;

namespace PublishSubscribe.Conceptual.Models
{
    class PubWithEventHandler
    {
        //This is generic EventHandler delegate where 
        //we define the type of argument want to send 
        //while raising our event, MyEventArgs in our case.
        public event EventHandler<MyEventArgs> OnChange = delegate { };

        public void Raise()
        {
            //Invoke OnChange Action
            //Lets pass MyEventArgs object with some random value
            OnChange(this, new MyEventArgs(33));
        }
    }
}
