public class GoalManager {
    private List<Goal> _goals;
    private int _score;

    public GoalManager() {
        _goals = new List<Goal>(){new SimpleGoal("First goal", "First goal description", 10)
        , new SimpleGoal("Second goal", "Second goal description", 20)
        , new SimpleGoal("Third goal", "Third goal description", 30)};
        _score = 0;
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
                    Console.WriteLine();
                    this.ListGoalDetails();
                    break;
                case "3":
                    Console.WriteLine("Case 3");
                    Console.WriteLine();
                    break;
                case "4":
                    Console.WriteLine("Case 4");
                    Console.WriteLine();
                    break;
                case "5":
                    RecordEvent();
                    Console.WriteLine();
                    break;
                case "6":
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


    public string DisplayMenu() {
        this.DisplayPlayerInfo();
        Console.WriteLine();
        Console.WriteLine("Menu Options");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");
        return Console.ReadLine();
    }

    public void DisplayPlayerInfo() {
        Console.WriteLine($"You have {this._score} points.");
    }

    private void ListGoalTypes() {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
    }

    public void ListGoalNames() {
        Console.WriteLine("The names of Goals are: ");
        for (int i = 0; i < this._goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails() {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            string checkMark = goal.IsComplete() ? "X" : " ";
            Console.WriteLine($"{i+1}. [{checkMark}] {goal.GetDetailsString()}");
        }
    }

    public void CreateGoal() {
        ListGoalTypes();

        Goal goalCreated;
    
        string goalType = GetGoalTypeFromUserInput("What type of goal would you like to create? ");
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        int goalPoints = GetIntNumbersFromUserInput("What is the amount of points associated with this goal? ");
        
        int target, bonus;
        if(goalType == "3") {
            target = GetIntNumbersFromUserInput("How many times does this goal need to be accomplished for a bonus? ");
            bonus = GetIntNumbersFromUserInput("What is the bonus for accomplishing it many times? ");
            goalCreated = new ChecklistGoal(goalName, goalDescription, goalPoints, target, bonus);
        } else if(goalType == "2") {
            goalCreated = new EternalGoal(goalName, goalDescription, goalPoints);
        } else { // This means goalType is 1
            goalCreated = new SimpleGoal(goalName, goalDescription, goalPoints);
        }

        this._goals.Add(goalCreated);
    }

    public void RecordEvent() {
        ListGoalNames();
        Goal accomplishedGoal;
        bool isInvalidInput = true;
        int chosenGoalInt;
        do {
            chosenGoalInt = GetIntNumbersFromUserInput("Which goal did you accomplish? ");
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
        Console.WriteLine($"Congratulations! You have earned {accomplishedGoal.GetPoints()} points!");
        this._score += accomplishedGoal.GetPoints();
        Console.WriteLine($"You have now {this._score} points.");
        Console.WriteLine();
    }

    public void SaveGoals() {
        // TODO: Implement this method.
    }

    public void LoadGoals() {

    }

    private int GetIntNumbersFromUserInput(string questionToUser) {
        bool isInvalidInput = true;
        int number;
        do
        {
            Console.Write(questionToUser);
            string userInput = Console.ReadLine();
            
            if(!int.TryParse(userInput, out number)) {
                Console.WriteLine("Invalid input. Please try again.");
                isInvalidInput = true;
            } else {
                isInvalidInput = false;
            }

        } while (isInvalidInput);

        return number;
        
    }

    private string GetGoalTypeFromUserInput(string qustionToUser) {
        bool isInvalidInput;
        string goalType = "";
        do
        {
            Console.Write(qustionToUser);
            string userInput = Console.ReadLine();

            if(userInput == "1" || userInput == "2" || userInput == "3") {
                goalType = userInput;
                isInvalidInput = false;
            } else {
                Console.WriteLine("Invalid input. Please try again.");
                isInvalidInput = true;
            }
        } while (isInvalidInput);

        return goalType;
    }
}