public class Scripture
{
    public Reference Reference { get; set; }
    public List<Word> Words { get; set; }

    public Scripture(Reference reference, List<Word> words)
    {
        Reference = reference;
        Words = words;
    }

    public void HideRandomWords(int count)
    {
        if (count >= Words.Count)
        {
            Console.WriteLine("Cannot hide more words than the total number of words.");
            return;
        }

        Random random = new Random();
        var wordsToHide = Words.OrderBy(_ => random.Next()).Take(count).ToList();

        foreach (var word in wordsToHide)
        {
            // Logic to hide the word (e.g., replace with blanks)
            word.Text = new string('_', word.Text.Length);
        }
    }

    public void DisplayScripture()
    {
        Console.WriteLine($"Scripture Reference: {Reference.GetDisplayText()}");
        Console.WriteLine("Scripture Text:");
        foreach (var word in Words)
        {
            Console.Write($"{word.Text} ");
        }
        Console.WriteLine();
    }
}
