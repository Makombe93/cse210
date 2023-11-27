using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a library of scriptures
        var scriptureLibrary = new ScriptureLibrary();

        if (scriptureLibrary != null)
        {
            // Get a random scripture from the library
            var scripture = scriptureLibrary.GetRandomScripture();

            // Display original scripture
            Console.WriteLine("Original Scripture:");
            scripture.DisplayScripture();

            // Hide random words and display modified scripture
            scripture.HideRandomWords(3);
            Console.WriteLine("\nScripture after hiding random words:");
            scripture.DisplayScripture();
        }
        else
        {
            Console.WriteLine("Error: Unable to initialize scripture library.");
        }
    }
}


