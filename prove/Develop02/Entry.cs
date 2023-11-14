public class Entry
{

    public string Date { get; set; }
    public string EntryText { get; set; }
    public string Prompt { get; set; }
    public Entry(string date, string entryText, string prompt)
    {
        Date = date;
        EntryText = entryText;
        Prompt = prompt;
    }

    
}