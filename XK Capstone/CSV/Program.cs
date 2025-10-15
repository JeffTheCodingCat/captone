namespace CSV;

class Program
{
    static void Main(string[] args)
    {
        try { List<string[]> stuff = ReadCSV(); }
        catch (Exception e) { Console.WriteLine(e.Message); }
    }
    public List<string[]> ReadCSV()
    {
        string line;
        List<string[]> rows = new List<string[]>();
        StreamReader sr = new StreamReader($"{System.AppDomain.CurrentDomain.BaseDirectory}/Sheet1.csv");
        line = sr.ReadLine();
        while (line != null)
        {
            line = sr.ReadLine();
            if (line != null)
            {
                string[] values = line.Split(',');
                foreach (string value in values)
                {
                    if (value.equals("")) { value = "<unknown>"; }
                }
                rows.Add(values);
            }
        }
        sr.Close();
        return rows;
    }
    public displayCSV(List<string[]> CSV)
    {
        foreach (string[] row in CSV)
        {
            foreach (string value in row)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
