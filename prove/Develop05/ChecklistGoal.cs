public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
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