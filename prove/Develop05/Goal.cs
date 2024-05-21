public abstract class Goal {
    private string _shortName;
    private string _description;
    private int _points;


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

    public virtual int GetPoints() {
        return this._points;
    }

    public abstract string GetStringRepresentation();
}