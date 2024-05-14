public class Assignment {
    protected string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic) {
        this._studentName = studentName;
        this._topic = topic;
    }

    public string GetSummary() {
        return $"{this._studentName} - {this._topic}";
    }


}