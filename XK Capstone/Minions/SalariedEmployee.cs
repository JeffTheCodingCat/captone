public class SalariedEmployee : Employee
{
    private double salary;
    public SalariedEmployee() : base()
    {
        salary = 0;
    }
    public SalariedEmployee(string fname, string lname, string EID, double Esal) : base(fname, lname, EID)
    {
        salary = Esal;
    }
    public override double getPay() => salary;
    public double money
    {
        get { return salary; }
        set { salary = value; }
    }
    public override string ToString()
    {
        return base.ToString() + $", Salary is ${salary} per year";
    }
}
