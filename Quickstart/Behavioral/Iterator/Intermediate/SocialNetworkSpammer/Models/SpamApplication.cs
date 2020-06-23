namespace SocialNetworkSpammer
{
    // The application class configures collections and iterators
    // and then passes them to the client code.
    class SpamApplication
    {
        private readonly ISocialNetwork _network;
        private readonly Spammer _spammer;

        public SpamApplication(SocialNetworkBrand type)
        {
            switch (type)
            {
                case SocialNetworkBrand.Facebook:
                    _network = new Facebook();
                    break;
                case SocialNetworkBrand.LinkedIn:
                    break;
                case SocialNetworkBrand.Twitter:
                    break;
                default:
                    break;
            }
            _spammer = new Spammer();
        }

        public void SendSpamToFriends(Profile profile)
        {
            var iterator = _network.CreateFriendsIterator(profile.GetId());
            _spammer.Send(iterator, "Very important message");
        }

        public void SendSpamToCoworkers(Profile profile)
        {
            var iterator = _network.CreateCoworkersIterator(profile.GetId());
            _spammer.Send(iterator, "Very important message");
        }
    }
}
