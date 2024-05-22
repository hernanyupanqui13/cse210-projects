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

    public string GetDescription(){
        return this._description;
    }

    public virtual int GetPointsWhenCompleted() {
        return this._points;
    }

    public abstract string GetStringRepresentation();
}