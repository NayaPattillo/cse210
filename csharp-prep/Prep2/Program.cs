using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage?: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        if (grade >= 90){Console.WriteLine("You have an A");}
        else if (grade >= 80){Console.WriteLine("You have a B");}
        else if (grade >= 70){Console.WriteLine("You have a C");}
        else if (grade >= 60){Console.WriteLine("You have a D");}
        else if (grade >= 70){Console.WriteLine("You have an F");}
        else {Console.WriteLine("Invalid input");}
    }
}