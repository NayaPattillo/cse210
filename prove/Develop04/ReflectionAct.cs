public class ReflectionAct : Activity {

    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();

    private void MakeLists(){
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public string Reflection(){
        MakeLists();
        Console.WriteLine("How many seconds would you like to do this activity for?: ");
        string _input = Console.ReadLine();
        int num = Int32.Parse(_input);

        DateTime _current = DateTime.Now;
        DateTime _duration = _current.AddSeconds(num);

        Activity reflection = new Activity();
        string _startMessage = reflection.Animation("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine(_startMessage);
        Console.WriteLine("Lets Begin...");

        var random = new Random();
        int _rand = random.Next(0, _prompts.Count);
        string _randPrompt = (_prompts[_rand]);
        Console.WriteLine(_randPrompt);

        while (DateTime.Now < _duration){
            foreach (string question in _questions){
                Console.WriteLine(question);
                Thread.Sleep(5000);
            }
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

/*
var words = scriptureString.Split(" ");
foreach (string word in words){
    scripture.Add(word);
}

var random = new Random();
int index = scripture.Count;

int wordIndex = random.Next(0, index);
string randWord = (scripture[wordIndex]);
scripture = scripture.Select( x => x.Replace(randWord, "_")).ToList();

    //scripture.ForEach(word => Console.WriteLine(word));

string newScripture = string.Join(" ", scripture);
return newScripture;
*/ 