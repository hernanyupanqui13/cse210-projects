abstract class Activity
{
    private DateTime _date;
    private int _durationMinutes;

    public Activity(DateTime date, int durationMinutes)
    {
        this._date = date;
        this._durationMinutes = durationMinutes;
    }

    public abstract double GetDistance();

    public virtual double GetSpeed()
    {
        double distance = GetDistance();
        double speed = (distance / _durationMinutes) * 60;
        return speed;
    }

    public virtual double GetPace()
    {
        double distance = GetDistance(); // in Km
        double pace = _durationMinutes / distance;// minutes per Kilometer
        return pace;
    }

    public string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        string distanceUnit = "km";
        string speedUnit = "kph";
        string paceUnit = "min per km";

        return $"{_date:dd MMM yyyy} {GetType().Name} ({_durationMinutes} min) - Distance {distance:F2} {distanceUnit}, Speed {speed:F2} {speedUnit}, Pace: {pace:F2} {paceUnit}";
    }

    public DateTime GetDate() 
    {
        return _date;
    }

    public int GetDurationInMinutos()
    {
        return _durationMinutes;
    }
    
}