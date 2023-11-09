public class Resume
{
    public string _personName;
    public List<Job> _jobs = new List<Job>();
    internal string _name;

    public void Display()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}
