using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public User(string name, string email)
        {
            UserId = IdGenerator.GenerateBookId();
            Name = name;
            Email = email;
        }
    }
}
