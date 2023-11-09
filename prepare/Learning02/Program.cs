using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Front Office Receptionist";
        job1._company = "Victory College";
        job1._startYear = 2018;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Executive Assistant";
        job2._company = "CICM Zambia";
        job2._startYear = 2020;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Batsirai Makombe";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}