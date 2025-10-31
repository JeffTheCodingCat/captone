namespace LinQ;

using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class Product
{
    public string Description { get; set; }
    public float Price { get; set; }
    public string Manufacturer { get; set; }
    public override string ToString()
    {
        return $"Description: {Description}, Price: {Price}, Manufacturer: {Manufacturer}";
    }
}