class Menu{

    private List<string> mainMenu, createGoalMenu;
    private int mainMenuSelection;

    public Menu(){
        mainMenu = new List<string>{
            "Menu Options:",
            "1. Create New Goal",
            "2. List Goals",
            "3. Save Goals", 
            "4. Load Goals",
            "5. Record Event",
            "6. Quit"
        };
        createGoalMenu = new List<string>{
            "Types of Goals:",
            "1. Simple Goals",
            "2. Eternal Goals",
            "3. Checklist Goals"
        };
    }

    public void DisplayMainMenu(){
        foreach(string menuItem in mainMenu){
            Console.WriteLine(menuItem);
        }
    }

    public void DisplayPoints(int _totalPoints){
        Console.WriteLine(string.Format("You have {0} total points\n", _totalPoints));
    }

    public int DisplayGetMainMenu(){
        Console.Write("Select a Menu Choice: ");
        return int.Parse(Console.ReadLine());
    }

    public int GetMainMenuSelection(){
        return mainMenuSelection;
    }

    public int DisplayGetCreateNewGoalMenu(){
        foreach (string menuItem in createGoalMenu){
            Console.WriteLine(menuItem);
        }
        Console.Write("Select a Menu Choice: ");
        return int.Parse(Console.ReadLine());
    }

}