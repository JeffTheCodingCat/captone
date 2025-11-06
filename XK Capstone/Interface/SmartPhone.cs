class SmartPhone : IPowerable//, IConnectable, IRechargable
{
    private string Ssid;
    private bool powered;
    private int BatteryLevel;
    public SmartPhone(string ssid)
    {
        Ssid = ssid;
        powered = false;
        BatteryLevel = 100;
    }
    public void PowerOn()
    {
        powered = true;
    }
    public void PowerOff()
    {
        powered = false;
    }
    public bool IsOn
    {
        get { return powered; }
    }
}