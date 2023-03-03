using System;

public class Prompts{

    public string entry = "";
    public string dateText = "";
    public Prompts(){}
    public void DisplayPrompt(){
        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person you talked to today?");
        prompts.Add("What was the best thing you ate today?");
        prompts.Add("What was the funnest thing you did today?");
        prompts.Add("Did you go anywhere intereting today?");
        prompts.Add("What did you dream about last night?");
        var random = new Random();
        int listindex = prompts.Count;
        int randomPrompt = random.Next(listindex);
        Console.WriteLine(prompts[randomPrompt]);
        entry = Console.ReadLine();
        
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
    }

}