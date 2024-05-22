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
}