using System;

namespace PublishSubscribe.Conceptual.Models
{
    public class PubBasic
    {
        //OnChange property containing all the 
        //list of subscribers callback methods
        public event Action OnChange = delegate { };

        public void Raise()
        {
            //Invoke OnChange Action
            OnChange();
        }
    }
}
