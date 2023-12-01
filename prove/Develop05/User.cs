
public class User
{
    private List<Goal> _goals;
    private int _score;

    public User()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            goal.RecordEvent();
            _score += goal.Points;
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nCurrent Goals:");
        foreach (var goal in _goals)
        {
            goal.Display();
        }

        Console.WriteLine($"\nTotal Score: {_score}\n");
    }
}
