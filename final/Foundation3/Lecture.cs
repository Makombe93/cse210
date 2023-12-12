class Lecture : Event
{
    private string Speaker;
    private int Capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, string address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }

    public override string GetSummary()
    {
        return GetFullDetails();
    }
}