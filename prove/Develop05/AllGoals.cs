class AllGoals{
    private List<Goal> allGoals = new List<Goal>();
    private int totalPoints;
    public AllGoals(){}

    public int getTotalPoints(){
        return totalPoints;
    }

    public void DisplayGoals(){
        if (allGoals.Count() == 0){
            Console.WriteLine("No goals");
        }
        foreach (Goal goal in allGoals){
            Console.WriteLine(goal.ToString());
        }
    }
    string _filePath = "";
    public string DisplayGetGoalFile(){
        Console.WriteLine("What file would you like to save to? (goals.txt): ");
        _filePath = Console.ReadLine();
        return _filePath;
    }

    public void SaveGoals(){
        if (allGoals.Count() == 0){
              Console.WriteLine("No goals");
              return;  
        }
        string fileToSave = DisplayGetGoalFile();
        List<string> saveGoals = new List<string>();
        saveGoals.Add(totalPoints.ToString());

        foreach (Goal goal in allGoals){
            saveGoals.Add(goal.ToCSVRecord());
        }

        saveLoadCSV.SaveToCSV(saveGoals, fileToSave);
        Console.WriteLine("Saved");
    }

    public void addGoal(Goal goal){
        allGoals.Add(goal);
    }

    public void LoadGoals(){
        var fileGoals = saveLoadCSV.LoadFromCSV(_filePath);

        Goal goal = null;
        foreach (string goalInFile in fileGoals){
            string[] goalParts = goalInFile.Split("|");
            int goalType = int.Parse(goalParts[0]);
            switch (goalType){
                case 1:
                    goal = new SimpleGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), bool.Parse(goalParts[4]));
                    break;
            }
            if (goal != null && allGoals.Contains(goal) == false){
                allGoals.Add(goal);
            }   
        }
        Console.WriteLine("\nGoals Loaded.\n");
    }

    public string DisplayGetLoadFile(){
        Console.Write("filename: ");
        return Directory.GetCurrentDirectory() + "\\Files\\" + Console.ReadLine();
    }

    public void DisplayGoalsRecordEvent(){
        Console.WriteLine("Goals: ");
        foreach (Goal goal in allGoals){
            Console.WriteLine(string.Format("{0} {1}", allGoals.IndexOf(goal) + 1, goal.getGoalName()));
        }
        Console.Write("Which goal was accomplished?: ");

        int recordEvent = int.Parse(Console.ReadLine())-1;
        allGoals[recordEvent].RecordEvent(DisplayGetLoadFile());
        totalPoints += allGoals[recordEvent].getGoalPoints();
        Console.WriteLine(string.Format("You have {0} total points", totalPoints.ToString()));
    }    
}