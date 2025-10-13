public class Payroll
{
    List<Employee> Job = new List<Employee>();
    public void Add(Employee goon)
    {
        Job.Add(goon);
    }
    public void printChecks()
    {
        foreach(Employee e in Job){ Console.WriteLine(e); }
    }
}