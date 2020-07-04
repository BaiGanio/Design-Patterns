namespace SocialNetworkSpammer
{
    interface IProfileIterator
    {
        Profile GetNext();
        bool HasMore();
    }
}
