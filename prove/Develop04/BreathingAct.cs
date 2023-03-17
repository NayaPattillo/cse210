public class BreathingAct : Activity{

    public string Breathing(){
        Console.WriteLine("How many seconds would you like to do this activity for?: ");
        string _input = Console.ReadLine();
        int num = Int32.Parse(_input);

        DateTime _current = DateTime.Now;
        DateTime _duration = _current.AddSeconds(num);

        Activity breathing = new Activity();
        string _startMessage = breathing.Animation("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine(_startMessage);
        Console.WriteLine("Lets Begin...");

        while (DateTime.Now < _duration){
            Console.WriteLine("Breath in...");
            for (int i=4; i>0; i--){
                Console.Write(i);
                Thread.Sleep(1000);
                Console.WriteLine("\b \b");
                
            }
            Console.WriteLine("Breath out...");
            for (int i=4; i>0; i--){
                Console.Write(i);
                Thread.Sleep(1000);
                Console.WriteLine("\b \b");
                
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