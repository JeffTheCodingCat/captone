namespace CSV;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<string[]> stuff = ReadCSV();
            displayCSV(stuff);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
    public static List<string[]> ReadCSV()
    {
        string line;
        List<string[]> rows = new List<string[]>();
        StreamReader sr = new StreamReader($"{System.AppDomain.CurrentDomain.BaseDirectory}/Sheet1.csv");
        line = sr.ReadLine();
        while (line != null)
        {
            string[] values = line.Split(',');
            rows.Add(values);
            line = sr.ReadLine();
        }
        sr.Close();
        return rows;
    }
    public static void displayCSV(List<string[]> CSV)
    {
        foreach (string[] row in CSV)
        {
            foreach (string value in row)
            {
                if (value == "") { Console.Write($"{"<unknown>",-20}"); }
                else { Console.Write($"{ value,-20}"); }
            }
            Console.WriteLine();
        }
    }
}
