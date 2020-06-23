using System;

namespace SocialNetworkSpammer.ConcreteCollections
{
    class Twitter : ISocialNetwork
    {
        public IProfileIterator CreateCoworkersIterator(string profileId)
        {
            throw new NotImplementedException();
        }

        public IProfileIterator CreateFriendsIterator(string profileId)
        {
            throw new NotImplementedException();
        }
    }
}
