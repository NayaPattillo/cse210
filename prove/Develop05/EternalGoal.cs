class EternalGoal : Goal{

    private const int goalType = 2;
    private bool goalCompete;
    public EternalGoal(){}

    public EternalGoal(string _goalName, string _goalDescription, int _points, bool _goalComplete)
     : base(_goalName, _goalDescription, _points){
        goalCompete = _goalComplete;
    }
    public override string ToCSVRecord(){
        return string.Format("{0}|{1}|{2}|{3}|{4}", goalType, getGoalName(), getGoalDescription(), getGoalPoints(), goalCompete);
    }
    public override string ToString(){
        return string.Format("[{0}] {1} ({2})", ((goalCompete == false)? "" : "X"), getGoalName(), getGoalDescription());
    }
    public override void RecordEvent(string fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            goalCompete = true;
        }
        goalCompete = false;
    }

}