public class Program
{
    static void Main()
    {
        User user = new User();

        SimpleGoal simpleGoal = new SimpleGoal("Run a Marathon", 1000);
        user.AddGoal(simpleGoal);

        EternalGoal eternalGoal = new EternalGoal("Read Scriptures", 100);
        user.AddGoal(eternalGoal);

        ChecklistGoal checklistGoal = new ChecklistGoal("Complete Checklist", 5, 100, 500);
        user.AddGoal(checklistGoal);

        user.RecordEvent(0); // Record event for running a marathon
        user.RecordEvent(1); // Record event for reading scriptures
        user.RecordEvent(2); // Record event for checklist goal

        user.DisplayGoals();
    }
}