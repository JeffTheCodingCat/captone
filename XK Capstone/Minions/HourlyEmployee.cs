public class HourlyEmployee : Employee
{
    private double rate;
    private int hoursPerWeek;
    public HourlyEmployee() : base()
    {
        rate = 0;
        hoursPerWeek = 0;
    }
    public HourlyEmployee(string fname, string lname, string EID, double Erate, int Ehours) : base(fname, lname, EID)
    {
        rate = Erate;
        hoursPerWeek = Ehours;
    }
    public override double getPay()
    {
        return rate * hoursPerWeek;
    }
    public double wage
    {
        get { return rate; }
        set { rate = value; }
    }
    public int hours
    {
        get { return hoursPerWeek; }
        set { hoursPerWeek = value; }
    }
    public override string ToString()
    {
        return base.ToString() + $", pay is ${rate} per hour and {hoursPerWeek} hours per week";
    }
}
