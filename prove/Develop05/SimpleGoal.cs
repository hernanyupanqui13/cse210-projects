public class SimpleGoal : Goal {
    private bool _isComplete;
    public SimpleGoal(string name, string description, string points) : base(name, description, points) {
        _isComplete = false;
    }

    public override void RecordEvent() {
        // TODO: Record an event
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}