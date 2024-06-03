class Cycling : Activity
{
    private double _speedKph;

    public Cycling(DateTime date, int durationMinutes, double speedKph) : base(date, durationMinutes)
    {
        this._speedKph = speedKph;
    }

    public override double GetDistance()
    {
        double durationInHours =  (double) this.GetDurationInMinutos() / 60;
        return _speedKph * durationInHours;
    }

    public override double GetSpeed()
    {
        return _speedKph;
    }
}