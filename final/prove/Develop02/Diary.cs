using System;

namespace Develop02
//Database program class
{
    class Diary
    {
        //private static string[] helpInEntry = {"What did you do to make a positive difference today?", "Write something inspiring that you read today.", "Write a positive thought to carry with you today.", "Write a positive affirmation.", "Report your progress on your current goals. "};
 
        public void PrintHomeScreen()
        {
            Console.WriteLine("Welcome to your journal!");
            Console.WriteLine("Please select one of the options below:");
            Console.WriteLine("1 - Add a journal entry");
            Console.WriteLine("2 - Search for journal entries");
            Console.WriteLine("3 - Delete journal entries");
            Console.WriteLine("4 - Finish");
            Console.Write("What would you like to do? ");
        }

        // public string PrintPrompts() 
        // {
        //     var rand = new Random();
        //     string randomSuggestion = helpInEntry[rand.Next(helpInEntry.Length)];
        //     return $"{randomSuggestion}";
        // }

        private Database database;
        //private Prompts prompt;

        public Diary()
        {
            database = new Database();
            //prompt = new Prompts();
        }

        private DateTime ReadDateTime()
        {
            Console.WriteLine("Enter date and time as e.g. [01/01/2023]:");
            DateTime dateTime;
            while (! DateTime.TryParse(Console.ReadLine(), out dateTime))
                Console.WriteLine("Error. Please try again: ");
            return dateTime;
        }
        public static string[] helpInEntry = {"What did you do to make a positive difference today?", "Write something inspiring that you read today.", "Write a positive thought to carry with you today.", "Write a positive affirmation.", "Report your progress on your current goals. "};
 
        public string PrintPrompts() 
        {
            var rand = new Random();
            string randomSuggestion = helpInEntry[rand.Next(helpInEntry.Length)];
            return $"{randomSuggestion}";
        }
    

        public void PrintEntries(DateTime day)
        {
            List<Entry> entries = database.FindEntries(day, false);
            foreach (Entry entry in entries)
                Console.WriteLine(entry);
        }

        public void AddEntry()
        {
            DateTime dateTime = ReadDateTime();
            //Add the random prompts here somehow:
            string prompt = PrintPrompts();
            Console.WriteLine(prompt);
            Console.WriteLine("Enter the entry text:");
            Console.Write(">");
            string text = Console.ReadLine();
            database.AddEntry(dateTime, text);
        }

        public void SearchEntries()
        {
            // Entering the date
            DateTime dateTime = ReadDateTime();
            // Searching for entries
            List<Entry> entries = database.FindEntries(dateTime, false);
            // Printing entries
            if (entries.Count() > 0)
            {
                Console.WriteLine("Entries found: ");
                foreach (Entry entry in entries)
                    Console.WriteLine(entry);
            }
            else
                // Nothing found
                Console.WriteLine("No entries were found.");
        }

        public void DeleteEntries()
        {
            Console.WriteLine("Entries with the same exact date and time will be deleted");
            DateTime dateTime = ReadDateTime();
            database.DeleteEntries(dateTime);
        }

    }
}