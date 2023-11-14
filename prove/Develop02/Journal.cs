public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(string date, string prompt, string response)
    {
        Entry newEntry = new Entry(date, prompt, response);
        _entries.Add(newEntry);
    }
    public List<Entry> GetEntries()
    {
        return _entries;
    }

    public void DisplayAll()
    {
        Console.WriteLine("Journal Entries:");
        foreach (var entry in _entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Response: {entry.EntryText}");
            Console.WriteLine();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"Date: {entry.Date}");
                writer.WriteLine($"Response: {entry.EntryText}");
                writer.WriteLine();
            }
        }
        Console.WriteLine($"Journal saved to {fileName}.");
    }

    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            _entries.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                Entry currentEntry = null;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line.StartsWith("Date: "))
                    {
                        if (currentEntry != null)
                        {
                            _entries.Add(currentEntry);
                        }
                        currentEntry = new Entry(line.Substring(6), "SomeEntryText", "SomePromptText");
                    }
                    else if (line.StartsWith("Response: "))
                    {
                        if (currentEntry != null)
                        {
                            currentEntry.EntryText = line.Substring(10);
                        }
                    }
                }
                if (currentEntry != null)
                {
                    _entries.Add(currentEntry);
                }
            }
            Console.WriteLine($"Journal loaded from {fileName}.");
        }
        else
        {
            Console.WriteLine("File not found. Please check the file path and try again.");
        }
    }
}
