class Program
{
    static void Main(string[] args)
    {
        Hotel Winterhaven = new Hotel(4);
        Console.WriteLine(Winterhaven.requestRoom("Joe Swanson"));
        Console.WriteLine(Winterhaven.requestRoom("Jimmy McFart"));
        Console.WriteLine(Winterhaven.requestRoom("Steven"));
        Console.WriteLine(Winterhaven.requestRoom("Shen"));
        Console.WriteLine(Winterhaven.requestRoom("Nolan"));
        Console.WriteLine(Winterhaven.requestRoom("Little Timmy"));
        Winterhaven.display();
        Winterhaven.cancelAndReassign(Winterhaven.rooms[2]);
        Winterhaven.display();
        Winterhaven.cancelAndReassign(Winterhaven.rooms[3]);
        Winterhaven.display();
        Winterhaven.cancelAndReassign(Winterhaven.rooms[0]);
        Winterhaven.display();
    }
}
