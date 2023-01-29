using System;

namespace Develop02
//Main program class
{
    class Program
    static void Main(string[] args)
    {
        JournalEntries journal = new JournalEntries();
        char option = '0';
        while(option != '4')
        {
            journal.PrintHomeScreen();
            Console.WriteLine("Choose an action: ");
            Console.WriteLine("1 - Add a journal entry");
            Console.WriteLine("2 - Search for journal entries");
            Console.WriteLine("3 - Delete journal entries");
            Console.WriteLine("4 - Finish");
            //still need to set variable option above
            option = Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch (option)
            {
                case '1':
                    journal.PrintPrompts();
                    journal.AddEntry();
                    break;
                case '2':
                    journal.SearchEntries();
                    break;
                case '3':
                    journal.DeleteEntries();
                    break;
                    case '4':
                    Console.WriteLine("Press any key to quit the program");
                    break;
                default:
                    Console.WriteLine("Error. Press any key to choose from options.");
                    break;
            }
            Console.ReadKey();
        }
        
    }

}
