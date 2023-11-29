class Activity
{
    protected int duration;

    public Activity(int duration)
    {
        this.duration = duration;
    }

    public virtual void Start()
    {
        Console.WriteLine("Starting activity...");
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Get ready to begin.");
        Pause(3);
    }

    public virtual void End()
    {
        Console.WriteLine("Great job! Activity completed.");
        Console.WriteLine($"You've completed the activity for {duration} seconds.");
        Pause(3);
    }

    protected void Pause(int seconds)
    {
        //Add pauses
        Console.WriteLine($"Pausing for {seconds} seconds...");
        // Adding a sleep as pause
        System.Threading.Thread.Sleep(seconds * 1000);
    }
}