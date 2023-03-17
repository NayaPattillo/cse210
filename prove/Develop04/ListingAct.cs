public class ListingAct : Activity{

    List<string> _listQuestions = new List<string>();

    List<string> _ListAnswers = new List<string>();

    private void QuestionList(){
        _listQuestions.Add("Who are people that you appreciate?");
        _listQuestions.Add("What are personal strengths of yours?");
        _listQuestions.Add("Who are people that you have helped this week?");
        _listQuestions.Add("Who are some of your personal heroes?");
    }

    public string Listing(){
        QuestionList();

        Activity reflection = new Activity();
        string _startMessage = reflection.Animation("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine(_startMessage);
        Console.WriteLine("When you would like to finish, type quit");
        Console.WriteLine("Lets Begin...");

        var random = new Random();
        int _rand = random.Next(0, _listQuestions.Count);
        string _randPrompt = (_listQuestions[_rand]);
        Console.WriteLine(_randPrompt);

        string answer = Console.ReadLine();

        while (answer != "quit"){
            _ListAnswers.Add(answer);
            answer = Console.ReadLine();
        }

        /*
        Activity _endMessage = new Activity();
        string end = _endMessage.EndMessage();
        return end;
        */
        string end = "Well done! You have completed this activity.";
        return end;
    }
}
