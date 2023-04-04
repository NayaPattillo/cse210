using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        List<string> activities = new List<string>();

        Running activity1 = new Running();
        string running = activity1.GetSummary(3, 68);
        activities.Add(running);

        Cycling activity2 = new Cycling();
        string cycling = activity2.GetSummary(5, 160);
        activities.Add(cycling);

        Swimming activity3 = new Swimming();
        string swimming = activity3.GetSummary(10, 40);
        activities.Add(swimming);

        foreach (string activity in activities){
            Console.WriteLine(activity);
        }
    }
}