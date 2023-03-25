using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        AllGoals allGoals = new AllGoals();
        int userMainMenuSelection = 0;

        while (userMainMenuSelection != 6){
            Menu menu = new Menu();
            menu.DisplayPoints(allGoals.getTotalPoints());
            menu.DisplayMainMenu();
            userMainMenuSelection = menu.DisplayGetMainMenu();

            switch (userMainMenuSelection){
                case 1:
                    int createNewGoalSelection = menu.DisplayGetCreateNewGoalMenu();
                    int menuSelection = menu.GetMainMenuSelection();
                    Goal goal = null;
                    switch (createNewGoalSelection){
                        case 1:
                            goal = new SimpleGoal();
                            goal.getGoalName();
                            goal.getGoalDescription();
                            goal.getGoalPoints();
                            break;

                        case 2:
                            goal = new EternalGoal();
                            goal.getGoalName();
                            goal.getGoalDescription();
                            goal.getGoalPoints();
                            break;

                        case 3:
                            goal = new ChecklistGoal();
                            goal.getGoalName();
                            goal.getGoalDescription();
                            goal.getGoalPoints();
                            var times = new ChecklistGoal();
                            times.getTimesCompleted();
                            break;
                    }
                    if (goal != null){
                        allGoals.addGoal(goal);
                    }
                    break;

                case 2:
                    allGoals.DisplayGoals();
                    break;

                case 3:
                    allGoals.SaveGoals();
                    break;

                case 4:
                    allGoals.LoadGoals();
                    break;
                case 5:
                    allGoals.DisplayGoalsRecordEvent();
                    break;
            }
        }


    }

}