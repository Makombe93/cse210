class ListingActivity : Activity
{
    private List<string> listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "What has been your memorable moment this week?",
    };

    public ListingActivity(int duration) : base(duration) { }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("Let's begin...");
        PerformListing();
        base.End();
    }

    private void PerformListing()
    {
        string prompt = listingPrompts[new Random().Next(listingPrompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("You have several seconds to begin thinking about the prompt...");
        Pause(5);

        Console.WriteLine("Start listing items...");
       
        Console.WriteLine("Listing completed!");
    }
}