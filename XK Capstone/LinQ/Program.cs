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
        DelegateTest.processArray(myArray, x => x + 1);
        foreach (int i in myArray) { Console.Write(i + " "); }
        Console.WriteLine();
        DelegateTest.processArray(myArray, x => x * 2);
        foreach (int i in myArray) { Console.Write(i + " "); }
        Console.WriteLine();
        Sort.bubbleSort(products, NameCompare);
        foreach (Product p in products)
        {
            Console.WriteLine(p);
        }
        Sort.bubbleSort(products, PriceCompare);
        foreach (Product p in products)
        {
            Console.WriteLine(p);
        }

        int[] numbers = { 6, 7, 4, 2, 9, 1 };
        int max = numbers.Max();
        Console.WriteLine($"Max: {max}");
        int priceMax = products.Max(p => (int)p.Price);
        Console.WriteLine($"Price Max: {priceMax}");
        int expensiveProducts = products.Count(p => p.Price > 100);
        Console.WriteLine($"Expensive Products: {expensiveProducts}");
        Product firstDewalt = products.First(Product => Product.Manufacturer == "Dewalt");
        Console.WriteLine($"First Dewalt: {firstDewalt}");
        var expensiveItems = ExpensiveItems(products);
        Console.WriteLine("Expensive Items: ");
        foreach (var item in expensiveItems)
        {
            Console.WriteLine(item);
        }
    }

    public static IEnumerable<Product> ExpensiveItems(IEnumerable<Product> products)
    {
        return products.Where(p => p.Price > products.Average(prod => prod.Price));
    }
    /* static int addOne(int x)
     {
         return x + 1;
     }
     static int doubleIt(int x)
     {
         return x * 2;
     }*/
    static int NameCompare(object o, object o2)
    {
        Product p = (Product)o;
        Product p2 = (Product)o2;
        return p.Description.CompareTo(p2.Description);
    }
    static int PriceCompare(object o, object o2)
    {
        Product p = (Product)o;
        Product p2 = (Product)o2;
        return p.Price.CompareTo(p2.Price);
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