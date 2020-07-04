namespace DP.Common.Models
{
    public class AppUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsConfirmed { get; set; }
        public Role Role { get; set; }
    }

    public enum Role
    {
        Admin, 
        Customer,
        Visitor
    }
}
