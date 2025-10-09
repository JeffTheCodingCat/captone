class Reservation
{
    string guestName;
    int roomNumber;
    public Reservation(string name, int number)
    {
        guestName = name;
        roomNumber = number;
    }
    public int getRoomNumber()
    {
        return roomNumber;
    }
    public string getGuestName()
    {
        return guestName;
    }
    public override string ToString()
    {
        return $"Guest: {guestName}, Room: {roomNumber}";
    }
}