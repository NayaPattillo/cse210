class ChecklistGoal : Goal{

    private const int goalType = 3;
    private bool goalCompete;
    private int timesComplete;
    private int complete = 0;
    public ChecklistGoal(){}

    public ChecklistGoal(string _goalName, string _goalDescription, int _points, bool _goalComplete)
     : base(_goalName, _goalDescription, _points){
        goalCompete = _goalComplete;
    }

    public int getTimesCompleted(){
        Console.WriteLine("How many times would you like to do this goal?");
        timesComplete = int.Parse(Console.ReadLine());
        return timesComplete;
    }

    public override string ToCSVRecord(){
        return string.Format("{0}|{1}|{2}|{3}|{4}|{5}", goalType, getGoalName(), getGoalDescription(), getGoalPoints(),getTimesCompleted(), goalCompete);
    }
    public override string ToString(){
        return string.Format("[{0}] {1} ({2})", ((goalCompete == false)? "" : "X"), getGoalName(), getGoalDescription());
    }
    public override void RecordEvent(List<Goal> goals){
        while (goalCompete == false){
            complete = complete + 1;
            if (complete == timesComplete){
                goalCompete = true;
            }
        }
    }

}