using System.Text.Json.Serialization;

[Serializable()]
public class ChecklistGoal : Goal
{
    [JsonInclude]
    private int _amountCompleted;
    [JsonInclude]
    private int _target;
    [JsonInclude]
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
        return $"Checklist Goal:{this.GetName()}|{this.GetDescription()}|{this.GetPoints()}|{this._bonus}|{this._target}|{this._amountCompleted}";
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

    public override int GetPoints()
    {
        if(IsComplete()) return base.GetPoints();
        else return this._bonus;
    }
}