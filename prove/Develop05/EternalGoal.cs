using System.Text.Json.Serialization;

[Serializable()]
public class EternalGoal : Goal
{
    public EternalGoal() {}
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) {}
    public override string GetStringRepresentation()
    {
        return $"Eternal Goal:{this.GetName()}|{this.GetDescription()}|{this._points}";
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void RecordEvent()
    {
        // Since we never complete an Eternal Goal, we don't need to do anything here.
    }
}