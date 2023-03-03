using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display Entries");
        Console.WriteLine("3.Load Last Entry");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");

        Console.WriteLine("What would you like to do?: ");
        string userInput = Console.ReadLine();

        JournalEntries _userEntry = new JournalEntries();
        Prompts _prompt = new Prompts();

        while (userInput != "5"){

            if (userInput == "1"){
                _prompt.DisplayPrompt();
            }
            else if (userInput == "2"){
                _userEntry.PrintEntries();
            }
            else if (userInput == "3"){
                Console.WriteLine(_prompt.entry);
                Console.WriteLine(_prompt.dateText);
            }
            else if (userInput == "4"){
                _userEntry.StoreEntry();
                Console.WriteLine("Entry Saved");
            }
            Console.WriteLine("What would you like to do?: ");
            userInput = Console.ReadLine();
        }
    }
}