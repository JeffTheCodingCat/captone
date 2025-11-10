class WirelessMouse : IPowerable, IRechargable
{
    private bool powered;
    private int batteryLevel;
    public WirelessMouse()
    {
        powered = false;
        batteryLevel = 0;
    }
    // IPowerable implementation
    public void PowerOn()
    {
        powered = true;
        Console.WriteLine("WirelessMouse is now ON");
    }
    public void PowerOff()
    {
        powered = false;
        Console.WriteLine("WirelessMouse is now OFF");
    }
    public bool IsOn
    {
        get { return powered; }
    }
    // IRechargable implementation
    public int BatteryLevel { get { return batteryLevel; } }
    public void Charge()
    {
        batteryLevel = 100;
    }
}