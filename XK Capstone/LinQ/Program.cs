namespace LinQ;

using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Product[] products =
        {
            new Product { Description = "chair", Price = 200.0f, Manufacturer = "Ashley" },
            new Product { Description = "hammer", Price = 10.00f, Manufacturer = "Dewalt" },
            new Product { Description = "box", Price = 5.00f, Manufacturer = "Able" },
            new Product { Description = "saw", Price = 150.00f, Manufacturer = "Dewalt" },
            new Product { Description = "table", Price = 400f, Manufacturer = "Ashley" }
        };
        var ManuA = from p in products
                    where p.Manufacturer.StartsWith("A")
                    select p.Manufacturer;
        foreach (var m in ManuA.Distinct()) { Console.WriteLine(m); }

        var DescManuA = from p in products
                        where p.Manufacturer.StartsWith("A")
                        select p.Description;
        foreach (var m in DescManuA) { Console.WriteLine(m); }

        var InfoA = from p in products
                    where p.Manufacturer.StartsWith("A")
                    select p;
        foreach (var m in InfoA) { Console.WriteLine(m); }

        var Info20 = from p in products
                        where p.Price < 20.0f
                        select p;
        foreach (var m in Info20) { Console.WriteLine(m); }

        var Info100_300 = from p in products
                            where p.Price < 300.0f && p.Price > 100.0f
                            select p;
        foreach (var m in Info100_300) { Console.WriteLine(m); }

        var priceOrderedProducts = from p in products
                                    orderby p.Price descending
                                    select p;
        foreach (var m in priceOrderedProducts) { Console.WriteLine(m); }

        var manuGroupedProducts = from p in products
                                    group p by p.Manufacturer into g
                                    orderby g.Key
                                    select g;
        foreach (var g in manuGroupedProducts)
        {
            Console.WriteLine(g.Key);
            foreach (var product in g)
            {
                Console.WriteLine($"\t{product.Description}\t{product.Price}");
            }
        } 
        string test = "computer";
        Console.WriteLine(test.stripVowels());
        Product napkins = new Product { Description = "napkins", Price = 1.50f, Manufacturer = "Johnny Napkinson III" };
        Product cheapNapkins = napkins.markDown(0.2f);
        Console.WriteLine(cheapNapkins);
        int[] myArray = { 1, 2, 3, 4, 5 };
        DelegateTest.processArray(myArray, addOne);
        foreach (int i in myArray) { Console.Write(i + " "); }
        Console.WriteLine();
        DelegateTest.processArray(myArray, doubleIt);
        foreach (int i in myArray) { Console.Write(i + " "); }
    }
    static int addOne(int x)
    {
        return x + 1;
    }
    static int doubleIt(int x)
    {
        return x * 2;
    }
}

public class Product
{
    public string Description { get; set; }
    public float Price { get; set; }
    public string Manufacturer { get; set; }
    public override string ToString()
    {
        return $"Description: {Description}, Price: {Price}, Manufacturer: {Manufacturer}";
    }
}