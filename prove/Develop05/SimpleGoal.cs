
using System.Text.Json;
using System.Text.Json.Serialization;
[Serializable()]
public class SimpleGoal : Goal {
    [JsonInclude]
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points) {
        _isComplete = isComplete;
    }
    public SimpleGoal(string name, string description, int points) : base(name, description, points) {
        _isComplete = false;
    }

    public override void RecordEvent() {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal:{this.GetName()}|{this.GetDescription()}|{this._points}|{this._isComplete}";
    }
}