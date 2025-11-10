class SmartTV : IPowerable, IConnectable
{
    private bool powered;
    private string SSID;
    public SmartTV(string ssid)
    {
        SSID = ssid;
        powered = false;
    }
    // IPowerable implementation
    public void PowerOn()
    {
        powered = true;
        Console.WriteLine("SmartTV is now ON");
    }
    public void PowerOff()
    {
        powered = false;
        Console.WriteLine("SmartTV is now OFF");
    }
    public bool IsOn
    {
        get { return powered; }
    }
    // IConnectable implementation
    public void Connect(string networkName)
    {
        if (powered)
        {
            SSID = networkName;
            Console.WriteLine("Connected to " + networkName);
        }
    }
    public void Disconnect()
    {
        SSID = "";
        Console.WriteLine("Disconnected from network");
    }
    public string Ssid { get { return SSID; } }
}