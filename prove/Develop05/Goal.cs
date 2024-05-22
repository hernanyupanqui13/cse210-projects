using System.Text.Json.Serialization;

[Serializable()]
[JsonDerivedType(typeof(SimpleGoal), 0)]
[JsonDerivedType(typeof(EternalGoal), 1)]
[JsonDerivedType(typeof(ChecklistGoal), 2)]
public abstract class Goal {
    [JsonInclude]
    private string _shortName;
    [JsonInclude]
    private string _description;
    [JsonInclude]
    private int _points;

    [JsonConstructor]
    protected Goal() {}

    public Goal(string name, string description, int points) {
        this._shortName = name;
        this._description = description;
        this._points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public string GetDetailsString() {
        return $"{this._shortName} ({this._description})";
    }

    public string GetName() {
        return this._shortName;
    }

    public string GetDescription(){
        return this._description;
    }

    public virtual int GetPoints() {
        return this._points;
    }

    public abstract string GetStringRepresentation();
}