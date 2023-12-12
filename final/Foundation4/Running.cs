class Running : Activity
{
    private double Distance;

    public Running(DateTime date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / LengthInMinutes * 60;
    }

    public override double GetPace()
    {
        return LengthInMinutes / Distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Type: Running Distance: {Distance} miles Speed: {GetSpeed()} mph Pace: {GetPace()} min/mile";
    }
}
