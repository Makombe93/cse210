public class Reference
{
    public string Book { get; set; }
    public int Chapter { get; set; }
    public int Verse { get; set; }

    // Constructors
    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
    }

    // Method to get formatted display text
    public string GetDisplayText()
    {
        return $"{Book} {Chapter}:{Verse}";
    }
}