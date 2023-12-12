class Event
{
    private string EventTitle;
    private string Description;
    private DateTime Date;
    private TimeSpan Time;
    private string Address;

    public Event(string title, string description, DateTime date, TimeSpan time, string address)
    {
        EventTitle = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {EventTitle}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {Address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"Type: Generic Event\nTitle: {EventTitle}\nDate: {Date.ToShortDateString()}";
    }

    public virtual string GetSummary()
    {
        return GetFullDetails(); 
    }
}
