class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> reflectionQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How has the experience made you feel?",
        "What can you learn from this experience?"
    };

    public ReflectionActivity(int duration) : base(duration) { }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine("Let's begin...");
        PerformReflection();
        base.End();
    }

    private void PerformReflection()
    {
        string prompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine(prompt);

        foreach (var question in reflectionQuestions)
        {
            Console.WriteLine(question);
            Pause(3);
        }
    }
}