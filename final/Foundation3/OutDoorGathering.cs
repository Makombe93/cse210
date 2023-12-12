class OutdoorGathering : Event
{
    public string WeatherForecast { get; private set; }
    public int MaximumAttendees { get; private set; }

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, string address, string weatherForecast, int maximumAttendees)
        : base(title, description, date, time, address)
    {
        WeatherForecast = weatherForecast;
        MaximumAttendees = maximumAttendees;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nWeather Forecast: {WeatherForecast}\nMaximum Attendees: {MaximumAttendees}";
    }

    public override string GetSummary()
    {
        return GetFullDetails();
    }
}
