class Running : Activity
{
    private double distanceKm;

    public Running(DateTime date, int durationMinutes, double distanceKm) : base(date, durationMinutes)
    {
        this.distanceKm = distanceKm;
    }

    public override double GetDistance()
    {
        return distanceKm;
    }
}