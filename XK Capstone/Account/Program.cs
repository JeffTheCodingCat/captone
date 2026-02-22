
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Account acc1 = new Account(1000, "Johnny-Bob");
        Account acc2 = new Account(500, "Peter Griffin");
        Console.WriteLine("Getting balance from account 1");
        Console.WriteLine($"Balance is: {acc1.getBalance()}");
        acc1.depoisit(250);
        Console.WriteLine("Deposited $250 into account 1, new info:");
        acc1.show();
        Console.WriteLine("Getting balance from account 2");
        Console.WriteLine($"Balance is: {acc2.getBalance()}");
        acc2.withdraw(250);
        Console.WriteLine("Withdrew $250 from account 2, new info:");
        acc2.show();
        acc2.transfer(acc1, 500);
        Console.WriteLine("Transferred $500 from account 1 into account 2, new info:");
        acc1.show();
        acc2.show();
        int? x1;
        int? x2;
        x1 = 20;
        x2 = null;
        nuhUh(x1);
        nuhUh(x2);
        string? s;
        s = null;
        Account? a = null;
        Console.WriteLine("Hello and welcome to MainChange the branch (awesome)");
        Console.WriteLine("im gonna make a change and then NOT commit it and switch because i am evil");
    }
    static void nuhUh(int? x)
    {
        if(x.HasValue){ Console.WriteLine($"parameter is equal to {x}"); }else{ Console.WriteLine("parameter has no value"); }
    }
}
