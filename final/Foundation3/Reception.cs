class Reception : Event
{
    private string RsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, string address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nRSVP Email: {RsvpEmail}";
    }

    public override string GetSummary()
    {
        return GetFullDetails();
    }
}