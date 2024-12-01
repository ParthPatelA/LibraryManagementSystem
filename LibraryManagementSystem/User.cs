using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public bool IsAvailable { get; set; } = true;
        private static readonly HashSet<int> generatedIds = new HashSet<int>();
        private static readonly Random random = new Random();

        public User(string name, string email)
        {
            UserId = GenerateUniqueRandomId();
            Name = name;
            Email = email;
        }
         public static int GenerateUniqueRandomId()
        {
            int newId;

            // Keep generating until we get a unique ID
            do
            {
                newId = random.Next(1, 1000); // Generate a random ID within a range
            } while (!generatedIds.Add(newId)); // Add to HashSet, ensures uniqueness

            return newId;
        }
    }
}
