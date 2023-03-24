class Goal{
    //private string _type;
    private string goalName;
    private string goalDescription;
    private int goalPoints;
    
    public Goal(){}

    public Goal(string _goalName, string _goalDescription, int _points)
    {
        //_type = type;
        goalName = _goalName;
        goalDescription = _goalDescription;
        goalPoints = _points;
    }
    public string getGoalName(){
        Console.WriteLine("What would you like to name your goal?");
        goalName = Console.ReadLine();
        return goalName;
    }
    public string getGoalDescription(){
        Console.WriteLine("Please describe your goal:");
        goalDescription = Console.ReadLine();
        return goalDescription;
    }
    public int getGoalPoints(){
        Console.WriteLine("How many points would you like your goal to be worth?");
        goalPoints = int.Parse(Console.ReadLine());
        return goalPoints;
    }

    public virtual string ToCSVRecord(){
        string display = $"{getGoalName()}({getGoalDescription()}) {getGoalPoints()}Points";
        return display;
    }
    public virtual void RecordEvent(string fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            
        }
    }

}