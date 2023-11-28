using System;
class Program
{
    static void Main(string[] args)
    {
        // Test MathAssignment
        MathAssignment mathAssignment = new MathAssignment("Batsirai Makombe", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Test WritingAssignment
        WritingAssignment writingAssignment = new WritingAssignment("Mary Moyo", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}
