using System;

class Program
{
    static void Main()
    {
        // Create videos
        Video video1 = new Video("How to lose weight in 30 days", "Batsirai Makombe", 120);
        Video video2 = new Video("7 Tips To Keep A House Clean", "Ms Cleans", 180);

        // Add comments to videos
        video1.AddComment("User1", "Great video!");
        video1.AddComment("User2", "Interesting content.");
        video2.AddComment("User3", "I enjoyed this.");

        // Show video details
        Console.WriteLine("Weight Loss Video Details:");
        video1.DisplayDetails();

        Console.WriteLine("\nClean House Tips Video Details:");
        video2.DisplayDetails();
    }
}