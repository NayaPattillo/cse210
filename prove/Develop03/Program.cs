using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Console.WriteLine("Would you like to see Scripture 1 or Scripture 2?: ");
        string choice = Console.ReadLine();

        Scripture _firstScripture = new Scripture();
        string _scripture1 = _firstScripture.GetScripture1();
        Reference _firstReference = new Reference();
        string _reference1 = _firstReference.GetReference1();

        string _verse1 = "";
        string _verse2 = "";

        Scripture _secondScripture = new Scripture(_verse1, _verse2);
        string _scripture2 = _secondScripture.GetScripture2();
        Reference _secondReference = new Reference(_verse1, _verse2);
        string _reference2 = _secondReference.GetReference2();

        
        string input = "";
        if (choice == "1"){
            Console.Clear();
            Console.WriteLine($"{_reference1}: {_scripture1}");
            Console.WriteLine("Type quit to quit, press Enter to continue: ");
            input = Console.ReadLine();
        
            while (input != "quit"){
                Word _word = new Word(_scripture1);
                string _newScripture = _word.GetReplacement();

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
                Word _word = new Word(_scripture2);
                string _newScripture = _word.GetReplacement();

                Console.Clear();
                Console.WriteLine(_newScripture);
                Console.WriteLine("Type quit to quit, press Enter to continue: ");
                input = Console.ReadLine();
            }
        }

    }
}