namespace Interface;

class Program
{
    static void Main(string[] args)
    {
        SmartPhone myPhone = new SmartPhone("HomeWiFi");
        myPhone.PowerOn();
        Console.WriteLine($"Phone is on: {myPhone.IsOn}");
    }
}
