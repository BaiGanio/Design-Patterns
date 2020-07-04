using System.Linq;

namespace SocialNetworkSpammer
{
    // Each concrete collection is coupled to a set of concrete
    // iterator classes it returns. But the client isn't, since the
    // signature of these methods returns iterator interfaces.
    class Facebook : ISocialNetwork
    {
        public IProfileIterator CreateCoworkersIterator(string profileId)
        {
            return new FacebookIterator(this, profileId, SocialNetworkCircle.Coworkers);
        }

        public IProfileIterator CreateFriendsIterator(string profileId)
        {
            return new FacebookIterator(this, profileId, SocialNetworkCircle.Friends);
        }

        internal Profile[] SocialGraphRequest(string profileId, SocialNetworkCircle type)
        {
            var profiles = SocialGraphData.GetProfiles();
            var profile = profiles.First(p => p.Id == profileId);

            Profile[] targetProfiles = null;
            switch (type)
            {
                case SocialNetworkCircle.Friends:
                    targetProfiles = profile.Friends;
                    break;
                case SocialNetworkCircle.Coworkers:
                    targetProfiles = profile.Coworkers;
                    break;
            }
            return targetProfiles;
        }
    }
}
