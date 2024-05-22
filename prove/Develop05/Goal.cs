using System.Text.Json.Serialization;

public abstract class Goal {
    private string _shortName;
    private string _description;
    protected int _points;


    public Goal(string name, string description, int points) {
        this._shortName = name;
        this._description = description;
        this._points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString() {
        return $"{this._shortName} ({this._description})";
    }

    public string GetName() {
        return this._shortName;
    }

    public void SetName(string newName) {
        this._shortName = newName;
    }

    // This is a getter for the description of the goal.
    public string GetDescription(){
        return this._description;
    }

    public void SetDescription(string newDescription) {
        this._description = newDescription;
    }
    
    // This is a getter for the points of the goal. It returns the points' member variable.
    public int GetPoints() {
        return this._points;
    }

    public void SetPoints(int newPoints) {
        this._points = newPoints;
    }


    // This method is used to get the points awarded when the goal is completed. 
    // Not necessarily the same as the points of the object, but by default it is 
    public virtual int GetPointsWhenCompleted() {
        return this._points;
    }

    public abstract string GetStringRepresentation();

    public virtual void EditGoal() {
        Console.WriteLine("What would you like to change?");
        Console.WriteLine("  1. Name");
        Console.WriteLine("  2. Description");
        Console.WriteLine("  3. Points");
        Console.WriteLine("  4. Cancel");

        int chosenInt = UserInputHandler.GetIntNumbersFromUserInput("Please enter the number of the change you would like to make: ", 1, 4);

        if(chosenInt == 1) {
            Console.Write("Please enter the new name: ");
            string newName = Console.ReadLine();
            this.SetName(newName);
            Console.WriteLine("Name changed successfully.");
        }

        if(chosenInt == 2) {
            Console.Write("Please enter the new description: ");
            string newDescription = Console.ReadLine();
            this.SetDescription(newDescription);
            Console.WriteLine("Description changed successfully.");
        }

        if(chosenInt == 3) {
            Console.Write("Please enter the new points: ");
            int newPoints = UserInputHandler.GetIntNumbersFromUserInput("Please enter the new points: ");
            this.SetPoints(newPoints);
            Console.WriteLine("Points changed successfully.");
        }
    }
}