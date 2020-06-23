namespace SocialNetworkSpammer
{
    class Profile
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Profile[] Friends { get; set; }
        public Profile[] Coworkers { get; set; }

        internal string GetId()
        {
            return Id;
        }

        internal string GetEmail()
        {
            return Email;
        }
    }
}
