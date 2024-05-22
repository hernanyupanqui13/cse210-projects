using System.IO;

public class GoalManager {
    private List<Goal> _goals;
    private int _score;

    public GoalManager(int initialScore, List<Goal> goals) {
        _goals = goals;
        _score = initialScore;
    }

    

    public void Start() {
        bool shouldQuit = false;

        while (!shouldQuit)
        {
            // Display the menu and get user input
            string userChoice = this.DisplayMenu();

            // Handle the user's choice
            switch (userChoice)
            {
                case "1":
                    CreateGoal();
                    Console.WriteLine();
                    break;
                case "2":
                    EditGoal();
                    Console.WriteLine();
                    break;
                case "3":
                    Console.WriteLine();
                    this.ListGoalDetails();
                    break;
                case "4":
                    SaveGoals();
                    Console.WriteLine();
                    break;
                case "5":
                    LoadGoals();
                    Console.WriteLine();
                    break;
                case "6":
                    RecordEvent();
                    Console.WriteLine();
                    break;
                case "7":
                    shouldQuit = true;
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine();
                    Console.WriteLine();
                    continue;
            }
        }
    }


    private string DisplayMenu() {
        this.DisplayPlayerInfo();
        Console.WriteLine();
        Console.WriteLine("Menu Options");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. Edit Goal");
        Console.WriteLine("  3. List Goals");
        Console.WriteLine("  4. Save Goals");
        Console.WriteLine("  5. Load Goals");
        Console.WriteLine("  6. Record Event");
        Console.WriteLine("  7. Quit");
        Console.Write("Select a choice from the menu: ");
        return Console.ReadLine();
    }

    private void DisplayPlayerInfo() {
        Console.WriteLine($"You have {this._score} points.");
    }

    private void ListdataTypes() {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
    }

    private void ListGoalNames() {

        if(this._goals.Count == 0) {
            Console.WriteLine("You have no goals yet.");
            return;
        }

        Console.WriteLine("The names of Goals are: ");
        for (int i = 0; i < this._goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetName()}");
        }
    }

    private void ListGoalDetails() {

        if(_goals.Count == 0) {
            Console.WriteLine("You have no goals yet.");
            return;
        }
        
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            string checkMark = goal.IsComplete() ? "X" : " ";
            Console.WriteLine($"{i+1}. [{checkMark}] {goal.GetDetailsString()}");
        }
    }

    private void CreateGoal() {
        ListdataTypes();

        Goal goalCreated;
    
        int dataType = UserInputHandler.GetIntNumbersFromUserInput("What type of goal would you like to create? ", 1, 3);
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        int goalPoints = UserInputHandler.GetIntNumbersFromUserInput("What is the amount of points associated with this goal? ");
        
        int target, bonus;
        if(dataType == 3) {
            target = UserInputHandler.GetIntNumbersFromUserInput("How many times does this goal need to be accomplished for a bonus? ");
            bonus = UserInputHandler.GetIntNumbersFromUserInput("What is the bonus for accomplishing it many times? ");
            goalCreated = new ChecklistGoal(goalName, goalDescription, goalPoints, target, bonus);
        } else if(dataType == 2) {
            goalCreated = new EternalGoal(goalName, goalDescription, goalPoints);
        } else { // This means dataType is 1
            goalCreated = new SimpleGoal(goalName, goalDescription, goalPoints);
        }

        this._goals.Add(goalCreated);
    }

    private void RecordEvent() {
        ListGoalNames();
        Goal accomplishedGoal;
        bool isInvalidInput = true;
        int chosenGoalInt;
        do {
            chosenGoalInt = UserInputHandler.GetIntNumbersFromUserInput("Which goal did you accomplish? ");
            if (chosenGoalInt > 0 && chosenGoalInt <= _goals.Count) {
                isInvalidInput = false;                
            } else {
                Console.WriteLine("Invalid input. Please try again.");
                isInvalidInput = true;
            }
        } while (isInvalidInput);

        accomplishedGoal = _goals[chosenGoalInt - 1];
        accomplishedGoal.RecordEvent();
        Console.WriteLine();
        Console.WriteLine($"Congratulations! You have earned {accomplishedGoal.GetPointsWhenCompleted()} points!");
        this._score += accomplishedGoal.GetPointsWhenCompleted();
        Console.WriteLine($"You have now {this._score} points.");
        Console.WriteLine();
    }

    private void SaveGoals() {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"Score:{this._score}");
            for (int i = 0; i < this._goals.Count; i++)
            {
                outputFile.WriteLine(this._goals[i].GetStringRepresentation());
            }
        }

        Console.WriteLine("All your progress was saved successfully!");

    }

    private void LoadGoals() {

        this._goals.Clear();

        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");

            string dataType = parts[0];
            string bodyData = parts[1];

            if(dataType == "Score") {
                this._score = int.Parse(bodyData);
            }

            if(dataType == "Simple Goal") {
                string[] simplebodyData = bodyData.Split("|");
                string name = simplebodyData[0];
                string description = simplebodyData[1];
                int points = int.Parse(simplebodyData[2]);
                bool isComplete = simplebodyData[3]=="True";
                SimpleGoal goal = new SimpleGoal(name, description, points, isComplete);
                this._goals.Add(goal);
            }

            if (dataType == "Eternal Goal") {
                string[] eternalbodyData = bodyData.Split("|");
                string name = eternalbodyData[0];
                string description = eternalbodyData[1];
                int points = int.Parse(eternalbodyData[2]);
                EternalGoal goal = new EternalGoal(name, description, points);
                this._goals.Add(goal);
            }

            if (dataType == "Checklist Goal") {
                string[] checklistbodyData = bodyData.Split("|");
                string name = checklistbodyData[0];
                string description = checklistbodyData[1];
                int points = int.Parse(checklistbodyData[2]);
                int bonus = int.Parse(checklistbodyData[3]);
                int target = int.Parse(checklistbodyData[4]);
                int current = int.Parse(checklistbodyData[5]);
                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus, current);
                this._goals.Add(goal);
            }
        }
    }

    private void EditGoal() {
        ListGoalNames();

        if(this._goals.Count == 0) {
            return;
        }

        Console.Write("Which goal would you like to edit? ");
        bool isInvalid = true;
        int chosenGoalInt = 0;
        do {
            chosenGoalInt = UserInputHandler.GetIntNumbersFromUserInput("Please enter the number of the goal you would like to edit: ");
            if(chosenGoalInt > this._goals.Count) {
                Console.WriteLine("Invalid input. Please try again.");
                isInvalid = true;
            } else isInvalid = false;
        } while (isInvalid);
        
        Goal chosenGoal = this._goals[chosenGoalInt - 1];
        
        chosenGoal.EditGoal();
        

    }
}