class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int durationMinutes, int laps) : base(date, durationMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return (double)laps * 50.0 / 1000.0;
    }
}