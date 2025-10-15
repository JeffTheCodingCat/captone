using System.Diagnostics;

namespace Kiddies;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        Student bill = new Student("bill", "English");
        bill.recordTest(50);
        bill.recordTest(100);
        Student sue = new Student("sue", "CS");
        sue.recordTest(75);
        sue.recordTest(85);
        students.Add(bill);
        students.Add(sue);
        GradStudent betty = new GradStudent("betty", "CS", "CS");
        students.Add(betty);
        foreach(Student s in students){ Console.WriteLine(s); }
    }
}
public class Student
{
    private string name;
    private string major;
    private List<int> scores = new List<int>();
    public Student()
    {
        name = "";
        major = "";
    }
    public Student(string n, string m)
    {
        name = n;
        major = m;
    }
    public string StudentName
    {
        get { return name; }
        set { name = value; }
    }
    public void recordTest(int score)
    {
        scores.Add(score);
    }
    public virtual string getDegree()
    {
        return "BS-" + major;
    }
    public int avg
    {
        get
        {
            int total = 0;
            foreach (int score in scores)
            {
                total += score;
            }
            if (total == 0) { return 0; }
            return total / scores.Count;
        }
    }
    public override string ToString()
    {
        return $"Name: {name}, Degree: {getDegree()}, Average Score: {avg}";
    }
}
public class GradStudent : Student
{
    private string research;
    public GradStudent() : base()
    {
        research = "undecided";
    }
    public GradStudent(string n, string m, string r) : base(n, m)
    {
        research = r;
    }
    public override string getDegree()
    {
        return "MS-" + research;
    }
}