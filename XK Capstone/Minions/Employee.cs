using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;


public abstract class Employee
{
    private string fname;
    private string lname;
    private string IDnum;
    private const int PTO = 30;
    private int ptoDaysTaken = 0;
    public Employee()
    {
        fname = "";
        lname = "";
        IDnum = "";
    }
    public Employee(string first, string last, string EID)
    {
        fname = first;
        lname = last;
        IDnum = EID;
    }
    public string firstname
    {
        get { return fname; }
        set { fname = value; }
    }
    public string lastname
    {
        get { return lname; }
        set { lname = value; }
    }
    public string number
    {
        get { return IDnum; }
        set { IDnum = value; }
    }
    public int ptotaken
    {
        get { return ptoDaysTaken; }
        set
        {
            ptoDaysTaken = value;
            if(ptoDaysTaken > PTO){ throw new ArgumentException("Too many pto days"); }
        }
        
    }
    public
    abstract double getPay();
    public override string ToString()
    {
        return $"Employee name is {fname} {lname}, ID number is {IDnum}, {ptoDaysTaken} PTO days taken";
    }
}


