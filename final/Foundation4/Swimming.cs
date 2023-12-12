class Swimming : Activity
{
    private int Laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50 / 1000; // Convert laps to kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / LengthInMinutes * 60;
    }

    public override double GetPace()
    {
        return LengthInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Type: Swimming Distance: {GetDistance()} km Speed: {GetSpeed()} kph Pace: {GetPace()} min/km";
    }
}