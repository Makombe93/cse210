public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What would you say was the highlight of the day?",
            "How did you see the Lord's hand in your life today?",
            "What was the strongest emotion you felt today?",
            "What good did you do today?",
            "If there is anything you would change about today, what would that be?",
            "Who did you interact with today?",
            "Would you say that your day was fruitful? Why?",
            "What goal can you set today that you would want to work on tomorrow?"
        };
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}