public abstract class Goal {
    private string _shortName;
    private string _description;
    private string _points;


    public Goal(string name, string description, string points) {
        this._shortName = name;
        this._description = description;
        this._points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public string GetDetailsString() {
        return "";
    }

    public abstract string GetStringRepresentation();
}