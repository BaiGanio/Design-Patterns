using System;

namespace SocialNetworkSpammer
{
    // Here is another useful trick: you can pass an iterator to a
    // client class instead of giving it access to a whole
    // collection. This way, you don't expose the collection to the
    // client.
    //
    // And there's another benefit: you can change the way the
    // client works with the collection at runtime by passing it a
    // different iterator. This is possible because the client code
    // isn't coupled to concrete iterator classes.
    class Spammer
    {
        public void Send(IProfileIterator iterator, string message)
        {
            var profile = iterator.GetNext();
            SendEmail(profile.GetEmail(), message);
            while (iterator.HasMore())
            {
                profile = iterator.GetNext();
                SendEmail(profile.GetEmail(), message);
            }
        }

        private void SendEmail(string email, string message)
        {
            Console.WriteLine($"Email is sent to {email} with message {message}!");
        }
    }
}
