using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment _a1 = new Assignment("Jane Doe", "Math");
        Console.WriteLine(_a1.GetSummary());

        MathAssignment _a2 = new MathAssignment("John Doe", "Math", "Textbook", "2-10");
        Console.WriteLine(_a2.GetSummary());
        Console.WriteLine(_a2.GetList());

        WritingAssignment _a3 = new WritingAssignment("1name 2name", "Writing", "Writing101");
        Console.WriteLine(_a3.GetSummary());
        Console.WriteLine(_a3.GetWritingInfo());
    }
}