namespace LibraryManagementSystem
{
    internal class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        private static int incrementId = -1;

        public User(string name, string email, string role)
        {
            UserId = ++incrementId;
            Name = name;
            Email = email;
            Role = role;
        }
    }
}
