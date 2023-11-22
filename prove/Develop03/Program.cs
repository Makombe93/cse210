using System;

class Program
{
    static void Main(string[] args)
    {
        var words = new List<Word>
        {
            new Word("In"),
            new Word("the"),
            new Word("beginning"),
            new Word("God"),
            new Word("created"),
            new Word("the"),
            new Word("heaven"),
            new Word("and"),
            new Word("the"),
            new Word("earth"),
        };

        var reference = new Reference("Genesis", 1, 1);
        var scripture = new Scripture(reference, words);

        // Display original scripture
        Console.WriteLine("Original Scripture:");
        scripture.DisplayScripture();

        // Hide random words and display modified scripture
        scripture.HideRandomWords(3);
        Console.WriteLine("\nScripture after hiding random words:");
        scripture.DisplayScripture();
    }
}
   