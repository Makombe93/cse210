public abstract class Goal
{
    protected string _description;
    protected int _points;

    public Goal(string description, int points)
    {
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {
        Console.WriteLine($"Event recorded for goal: {_description}");
    }

    public virtual void Display()
    {
        Console.WriteLine($"{_description} [{(_points > 0 ? "Incomplete" : "Complete")}]");
    }

    public int Points => _points;
}
