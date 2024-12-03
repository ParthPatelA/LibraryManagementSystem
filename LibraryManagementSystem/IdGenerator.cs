using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace LibraryManagementSystem
{
    public static class IdGenerator
    {
        private static readonly string idFilePath = "LastGeneratedIds.json";
        private static int lastBookId;
        private static int lastUserId;

        static IdGenerator()
        {
            // Try loading the last generated IDs from the file
            if (File.Exists(idFilePath))
            {
                try
                {
                    string json = File.ReadAllText(idFilePath);
                    var ids = JsonConvert.DeserializeObject<Dictionary<string, int>>(json);

                    // Null check to avoid errors
                    if (ids != null)
                    {
                        lastBookId = ids.ContainsKey("BookId") ? ids["BookId"] : 0;
                        lastUserId = ids.ContainsKey("UserId") ? ids["UserId"] : 0;
                    }
                    else
                    {
                        Console.WriteLine("Warning: ID data in file is null, resetting to default.");
                        lastBookId = 0;
                        lastUserId = 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading ID data: {ex.Message}");
                    lastBookId = 0;
                    lastUserId = 0;
                }
            }
            else
            {
                lastBookId = 0;
                lastUserId = 0;
            }
        }

        public static int GenerateBookId()
        {
            lastBookId++;
            SaveIdsToFile();
            return lastBookId;
        }

        public static int GenerateUserId()
        {
            lastUserId++;
            SaveIdsToFile();
            return lastUserId;
        }

        private static void SaveIdsToFile()
        {
            try
            {
                var ids = new Dictionary<string, int>
                {
                    { "BookId", lastBookId },
                    { "UserId", lastUserId }
                };

                string json = JsonConvert.SerializeObject(ids, Formatting.Indented);
                File.WriteAllText(idFilePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving ID data: {ex.Message}");
            }
        }
    }
}
