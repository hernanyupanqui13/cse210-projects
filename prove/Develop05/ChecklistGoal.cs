using System.Text.Json.Serialization;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points) {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal:{this.GetName()}|{this.GetDescription()}|{this._points}|{this._bonus}|{this._target}|{this._amountCompleted}";
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target) return true;
        else return false;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override int GetPointsWhenCompleted()
    {
        if(IsComplete()) return this._bonus;
        else return this._points;
    }

    public override string GetDetailsString() {
        return $"{base.GetName()} ({base.GetDescription()}) -- Currently completed {this._amountCompleted}/{this._target}";
    }

    public void SetTarget(int newTarget) {
        _target = newTarget;
    }

    public void SetBonus(int newBonus) {
        _bonus = newBonus;
    }


    public override void EditGoal() {
        Console.WriteLine("What would you like to change?");
        Console.WriteLine("  1. Name");
        Console.WriteLine("  2. Description");
        Console.WriteLine("  3. Points");
        Console.WriteLine("  4. Target");
        Console.WriteLine("  5. Bonus");
        Console.WriteLine("  6. Cancel");

        int chosenInt = UserInputHandler.GetIntNumbersFromUserInput("Please enter the number of the change you would like to make: ", 1, 6);
        
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
            int newPoints = UserInputHandler.GetIntNumbersFromUserInput("Please enter the new points: ");
            this.SetPoints(newPoints);
            Console.WriteLine("Points changed successfully.");
        }

        if(chosenInt == 4) {
            int newTarget = UserInputHandler.GetIntNumbersFromUserInput("Please enter the new target: ");
            this.SetTarget(newTarget);
            Console.WriteLine("Target changed successfully.");
        }

        if(chosenInt == 5) {
            int newBonus = UserInputHandler.GetIntNumbersFromUserInput("Please enter the new bonus: ");
            this.SetBonus(newBonus);
            Console.WriteLine("Bonus changed successfully.");
        }
    }
}