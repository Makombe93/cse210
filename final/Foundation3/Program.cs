using System;

class Program
{
    static void Main()
    {
        Lecture lectureEvent = new Lecture("AI Conference", "Exploring the Future of AI", DateTime.Now, new TimeSpan(14, 0, 0), "26 Chuswe Road, Chilenje", "Mr Phiri", 100);
        Reception receptionEvent = new Reception("Networking Night", "An Evening of Networking", DateTime.Now.AddDays(7), new TimeSpan(18, 0, 0), "2 Olimpic drive, Avondale", "rsvp@elevation.zm");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Summer BBQ", "Enjoy BBQ in the Park!", DateTime.Now.AddDays(3), new TimeSpan(18, 0, 0), "Tiffany's Gardens, Roma Park", "Sunny", 200);


        Console.WriteLine("Lecture Details:");
        Console.WriteLine(lectureEvent.GetSummary());
        Console.WriteLine();

        Console.WriteLine("Reception Details:");
        Console.WriteLine(receptionEvent.GetSummary());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Details:");
        Console.WriteLine(outdoorEvent.GetSummary());
    }
}