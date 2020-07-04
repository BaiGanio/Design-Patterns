namespace SocialNetworkSpammer
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new SpamApplication(SocialNetworkBrand.Facebook);
            app.SendSpamToFriends(SocialGraphData.GetJohnSocialGraph());
        }
    }
}
