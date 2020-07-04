namespace SocialNetworkSpammer
{
    interface ISocialNetwork
    {
        IProfileIterator CreateFriendsIterator(string profileId);
        IProfileIterator CreateCoworkersIterator(string profileId);
    }
}
