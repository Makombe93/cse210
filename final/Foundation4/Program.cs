using System;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Now, 30, 3.0),
            new Cycling(DateTime.Now.AddDays(1), 45, 15.0),
            new Swimming(DateTime.Now.AddDays(2), 20, 15)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}