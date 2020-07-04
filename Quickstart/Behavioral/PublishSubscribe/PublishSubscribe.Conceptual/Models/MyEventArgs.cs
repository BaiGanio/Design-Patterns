using System;

namespace PublishSubscribe.Conceptual.Models
{
    //Define event argument you want to send while raising event.
    public class MyEventArgs : EventArgs
    {
        public int Value { get; set; }

        public MyEventArgs(int value)
        {
            Value = value;
        }
    }
}
