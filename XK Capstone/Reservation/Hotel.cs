using System.Reflection.Metadata;

class Hotel
{
    public Reservation[] rooms;
    private List<string> waitList;
    public Hotel(int rooms){ this.rooms = new Reservation[rooms]; waitList = new List<string>(); }
    public void display()
    {
        foreach (Reservation res in rooms)
        {
            Console.WriteLine(res);
        }
        Console.Write("Waitlist: ");
        foreach (string guy in waitList)
        {
            Console.Write($"{guy}, ");
        }
        Console.WriteLine();
    }
    public Reservation requestRoom(string guestName)
    {
        for (int i = 0; i < rooms.Length; i++)
        {
            if (rooms[i] == null)
            {
                rooms[i] = new Reservation(guestName, i);
                return rooms[i];
            }
        }
        waitList.Add(guestName);
        Console.WriteLine("Added to waitlist");
        return null;
    }
    public Reservation cancelAndReassign(Reservation res)
    {
        rooms[res.getRoomNumber()] = null;
        if(waitList == null){ return null; }
        requestRoom(waitList[0]);
        waitList.Remove(waitList[0]);
        return rooms[res.getRoomNumber()];
    }
    
}