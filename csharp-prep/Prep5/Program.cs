using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        void DisplayWelcome(){
            Console.WriteLine("Welcome to the program!");
        }

        string PromptUserName(){
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        int PromptUserNum(){
            Console.WriteLine("Please enter a number: ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        int SquareNum(int num){
            int square = num * num;
            return square;
        }

        void DisplayResult(string name, int square){
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int userNum = PromptUserNum();
        int squared = SquareNum(userNum);
        DisplayResult(name, squared);
    }
}