using System.Reflection.Metadata.Ecma335;

namespace CSV2;
//  StreamReader sr = new StreamReader($"{System.AppDomain.CurrentDomain.BaseDirectory}/Attendence.csv");

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<Attendence>> myArray = buildArray();
        try
        {
            printSectionOne(myArray);
            printSectionTwo(myArray);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
    public static Dictionary<string, List<Attendence>> buildArray()
    {
        Dictionary<string, List<Attendence>> attendenceData = new Dictionary<string, List<Attendence>>();
        StreamReader sr = new StreamReader($"{System.AppDomain.CurrentDomain.BaseDirectory}/Attendence.csv");
        sr.ReadLine();
        string line;

        while ((line = sr.ReadLine()) != null)
        {
            string[] words = line.Split(',');
            //if words[1] is in dictionary then add the data under that id; add the attendence data to existing list else:
            Attendence att = new Attendence(words[0], words[1], words[2], words[3], words[4]);
            if (attendenceData.ContainsKey(words[1]))
            {
                attendenceData[words[1]].Add(att);
            }
            else
            {
                attendenceData.Add(att.ID, [att]);
            }
        }
        sr.Close();
        return attendenceData;
    }


    public static void printSectionOne(Dictionary<string, List<Attendence>> data)
    {
        foreach (KeyValuePair<string, List<Attendence>> student in data)
        {
            string studentId = student.Key;
            List<Attendence> studentData = student.Value;
            string studentName = studentData[0].Name;
            Console.WriteLine("Student ID: " + studentId);
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("{0,15}{1,15}{2,15}", "Date", "Course", "Event");
            Console.WriteLine("{0,15}{1,15}{2,15}", "======", "======", "======");
            foreach (Attendence att in studentData)
            {
                Console.WriteLine("{0,15}{1,15}{2,15}", att.Date, att.Course, att.Event);
            }


            Console.WriteLine();


        }
    }
    public static void printSectionTwo(Dictionary<string, List<Attendence>> data)
    {
        Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", "StudentID", "Name", "Absences", "Tardies");
        Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", "=========", "====", "========", "=======");


        foreach (KeyValuePair<string, List<Attendence>> student in data)
        {
            string studentId = student.Key;
            string studentName = student.Value[0].Name;
            int absences = 0;
            int tardies = 0;
            foreach (Attendence att in student.Value)
            {
                if (att.Event.Equals("Absent"))
                    absences++;
                else if (att.Event.Equals("Tardy"))
                    tardies++;
            }


            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", studentId, studentName, absences, tardies);


        }
    }
}


public struct Attendence
{
    public Attendence(string Date, string ID, string Name, string Course, string Event)
    {
        this.Date = Date;
        this.ID = ID;
        this.Name = Name;
        this.Course = Course;
        this.Event = Event;
    }
    public string Date { get; }
    public string ID { get; }
    public string Name { get; }
    public string Course { get; }
    public string Event { get; }
}


