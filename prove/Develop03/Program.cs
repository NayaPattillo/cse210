using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Console.WriteLine("Would you like to see Scripture 1 or Scripture 2?: ");
        string choice = Console.ReadLine();

        Scripture firstScripture = new Scripture();
        string _scripture1 = firstScripture.GetScripture1();
        Reference firstReference = new Reference();
        string _reference1 = firstReference.GetReference1();

        string verse1 = "";
        string verse2 = "";

        Scripture secondScripture = new Scripture(verse1, verse2);
        string _scripture2 = secondScripture.GetScripture2();
        Reference secondReference = new Reference(verse1, verse2);
        string _reference2 = secondReference.GetReference2();

        
        string input = "";
        if (choice == "1"){
            Console.Clear();
            Console.WriteLine($"{_reference1}: {_scripture1}");
            Console.WriteLine("Type quit to quit, press Enter to continue: ");
            input = Console.ReadLine();
        
            while (input != "quit"){
                Word makelist = new Word(_scripture1);
                Word replace = new Word();
                string _newScripture = replace.GetReplacement();

                Console.Clear();
                Console.WriteLine(_newScripture);
                Console.WriteLine("Type quit to quit, press Enter to continue: ");
                input = Console.ReadLine();
            }
        }
        else if (choice == "2"){
            Console.Clear();
            Console.WriteLine($"{_reference2}: {_scripture2}");
            Console.WriteLine("Type quit to quit, press Enter to continue: ");
            input = Console.ReadLine();

            while (input != "quit"){
                Word makelist = new Word(_scripture2);
                Word replace = new Word();
                string _newScripture = replace.GetReplacement();

                Console.Clear();
                Console.WriteLine(_newScripture);
                Console.WriteLine("Type quit to quit, press Enter to continue: ");
                input = Console.ReadLine();
            }
        }

    }
}