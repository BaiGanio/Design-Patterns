using System;

namespace SocialNetworkSpammer
{
    static class SocialGraphData
    {
        private static readonly Profile bugsy = new Profile()
        {
            Id = Guid.NewGuid().ToString(),
            Name = "JBugs Bunny",
            Email = "bugsy@domain.com"
        };

        private static readonly Profile daffy = new Profile()
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Daffy Duck",
            Email = "daffy@domain.com"
        };

        private static readonly Profile taz = new Profile()
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Tazmanian Devil",
            Email = "taz@devil.com"
        };

        private static readonly Profile john = new Profile()
        {
            Id = Guid.NewGuid().ToString(),
            Name = "John Doe",
            Email = "john@doe.com",
            Friends = new Profile[] { taz, bugsy },
            Coworkers = new Profile[] { bugsy, daffy }
        };

        public static Profile GetJohnSocialGraph()
        {
            return john;
        }
        public static Profile[] GetProfiles()
        {
            return new Profile[] { bugsy, daffy, taz, john };
        }
    }
}
