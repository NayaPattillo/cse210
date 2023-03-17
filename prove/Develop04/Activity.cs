public class Activity{
    public string Menu(){
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");
        Console.WriteLine("4. Quit");
        string menu = "Which activity would you like to do?";
        return menu;
    }

    
    int i = 0;
    public string Animation(string _endMessage){
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(10);
        while (DateTime.Now > end){
            string a = animation[i];
            Console.Write(a);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;
            if (i >= animation.Count){
                i = 0;
            }
        }
        return _endMessage;
    }

    protected string _input = "";
    protected string EndMessage(){
        string _message = $"Great Job! You've made it to the end. You did this activity for {_input} seconds";
        return _message;
    }

    /*
    protected void Duration(){
        Console.WriteLine("How many seconds would you like to do this activity for?: ");
        string _input = Console.ReadLine();
        int num = Int32.Parse(_input);

        DateTime _current = DateTime.Now;
        DateTime _duration = _current.AddSeconds(num); 
    }
    */

    /*
    public void displaySpinner(int numSecondsToRun)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        
        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            spinnerCounter++;        
            switch (spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }
 
        Console.Write(" ");
    } 
    /*
    public void displayCountDown(int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i >= 1; i--)
        {            
            Console.Write(string.Format("You may begin in: {0}", i));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }
    */

}