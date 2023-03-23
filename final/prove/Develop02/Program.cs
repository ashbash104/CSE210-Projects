using System;

namespace Develop02
//Main program class
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary journal = new Diary();
            //Prompts prompt = new Prompts();
            char option = '0';
            while(option != '4')
            {
                journal.PrintHomeScreen();
                // If this doesn't work then just paste the code from the method back here
                //still need to set variable option above
                option = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (option)
                {
                    case '1':
                    //Am I gonna do the random prompt thing here from prompt class?
                        //prompt.PrintPrompts();
                        journal.AddEntry();
                        //journal.PrintPrompts();
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
}
