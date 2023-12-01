public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string description, int targetCount, int points, int bonusPoints) : base(description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        _currentCount++;

        if (_currentCount == _targetCount)
        {
            _points += _bonusPoints;
            Console.WriteLine($"Bonus points ({_bonusPoints}) earned for completing {_description}!");
        }
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Completed {_currentCount}/{_targetCount} times");
    }
}
