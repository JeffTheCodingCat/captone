using System.ComponentModel.DataAnnotations;

namespace Text_File;

class Program
{
    static void Main(string[] args)
    {
        Display("data.txt");
        Limit("data.txt", 5);
        Reverse("data.txt");
        Copy("data.txt", "copy.txt");
    }
    static void Display(string s)
    {
        string line;
        //Pass the file path and file name to the StreamReader constructor
        StreamReader sr = new StreamReader($"{System.AppDomain.CurrentDomain.BaseDirectory}/{s}");
        //Read the first line of text
        line = sr.ReadLine();
        //Continue to read until you reach end of file
        while (line != null)
        {
            //write the line to console window
            Console.WriteLine(line);
            //Read the next line
            line = sr.ReadLine();
        }
        //close the file
        sr.Close();
    }
    static void Limit(string s, int limit)
    {
        string line;
        StreamReader sr = new StreamReader($"{System.AppDomain.CurrentDomain.BaseDirectory}/{s}");
        line = sr.ReadLine();
        while (line != null)
        {
            if (line.Length > limit) { Console.WriteLine(line.Substring(0, limit)); }
            else { Console.WriteLine(line); }
            line = sr.ReadLine();
        }
        sr.Close();
    }
    static void Reverse(string s)
    {
        List<string> lines = new List<string>();
        string line;
        StreamReader sr = new StreamReader($"{System.AppDomain.CurrentDomain.BaseDirectory}/{s}");
        line = sr.ReadLine();
        while (line != null)
        {
            lines.Add(line);
            line = sr.ReadLine();
        }
        sr.Close();
        sr = new StreamReader($"{System.AppDomain.CurrentDomain.BaseDirectory}/{s}");
        line = sr.ReadLine();
        for (int i = lines.Count; i > 0; i--)
        {
            Console.WriteLine(lines[i - 1]);
            line = sr.ReadLine();
        }
        sr.Close();
    }
    static void Copy(string orig, string copy)
    {
        List<string> lines = new List<string>();
        string line;
        StreamReader sr = new StreamReader($"{System.AppDomain.CurrentDomain.BaseDirectory}/{orig}");
        line = sr.ReadLine();
        while (line != null)
        {
            lines.Add(line);
            line = sr.ReadLine();
        }
        sr.Close();
        StreamWriter sw = new StreamWriter($"{System.AppDomain.CurrentDomain.BaseDirectory}/{copy}");
        foreach (string l in lines) { sw.WriteLine(l); }
        sw.Close();
    }
}
