using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = -1;
        while (guess != magicNumber)
        {
            Console.Write("What number am I thinking of? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Nope, higher then that.");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Nope, lower then that.");
            }
            else
            {
                Console.WriteLine("Yep! You guessed it!");
            }

        } 
    }
}