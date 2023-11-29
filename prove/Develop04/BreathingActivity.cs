class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration) { }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        Console.WriteLine("Clear your mind and focus on your breathing.");
        Console.WriteLine("Let's begin...");
        PerformBreathing();
        base.End();
    }

    private void PerformBreathing()
    {
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Pause(2);
            Console.WriteLine("Breathe out...");
            Pause(2);
        }
    }
}