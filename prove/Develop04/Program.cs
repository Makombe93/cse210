using System;

class Program
{
    static void Main()
    {
        //BreathingActivity
        BreathingActivity breathingActivity = new BreathingActivity(60);
        breathingActivity.Start();

        //ReflectionActivity
        ReflectionActivity reflectionActivity = new ReflectionActivity(120);
        reflectionActivity.Start();

        //ListingActivity
        ListingActivity listingActivity = new ListingActivity(180);
        listingActivity.Start();
    }
}