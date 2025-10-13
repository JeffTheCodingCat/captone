using System.Globalization;


namespace Minions;


class Program
{
    static void Main(string[] args)
    {
        Payroll GoofenshmirtzEvilInc = new Payroll();
        SalariedEmployee DrGoof = new SalariedEmployee { firstname = "Dr.", lastname = "Goof", number = "00001", money = 100000000 };
        HourlyEmployee platypus = new HourlyEmployee { firstname = "A", lastname = "platypus", number = "00503", wage = 7, hours = 15 };
        SalariedEmployee Jerry = new SalariedEmployee { firstname = "Jerry", lastname = "the platypus", number = "00504", money = 150000 };
        HourlyEmployee Finn = new HourlyEmployee("Finnegan", "Triangle", "01037", 14.50, 22);
        HourlyEmployee Herb = new HourlyEmployee("Herbert", "Rectangle", "01038", 15.50, 25);
        SalariedEmployee Izzy = new SalariedEmployee("Isabelle", "Doombringer", "01500", 87000);
        DrGoof.ptotaken = 0;
        platypus.ptotaken = 1;
        tryJerry.ptotaken = 5;
        Finn.ptotaken = 11;
        Herb.ptotaken = 3;
        Izzy.ptotaken = 30;
        GoofenshmirtzEvilInc.Add(DrGoof);
        GoofenshmirtzEvilInc.Add(platypus);
        GoofenshmirtzEvilInc.Add(Jerry);
        GoofenshmirtzEvilInc.Add(Finn);
        GoofenshmirtzEvilInc.Add(Herb);
        GoofenshmirtzEvilInc.Add(Izzy);
        GoofenshmirtzEvilInc.printChecks();
    }
}