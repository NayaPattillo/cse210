using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        int input = -1;

        while (input != 0){
            Console.WriteLine("Enter list of numbers, type 0 when done: ");
            input = int.Parse(Console.ReadLine());

             if (input != 0)
            {
                numbers.Add(input);
            }
        }

        int sum = 0;
        foreach (int number in numbers){
            sum += number;
        }
        Console.WriteLine($"The sum of your numbers is {sum}.");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of your numbers is: {average}.");

        int max = numbers[0];
        foreach (int number in numbers){
            if (number > max){
                max = number;
            }
        }
        Console.WriteLine($"The highest number listed is {max}.");

    }
}