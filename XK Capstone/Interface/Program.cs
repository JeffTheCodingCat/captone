namespace Interface;

class Program
{
    static void Main(string[] args)
    {
        SmartPhone homePhone = new SmartPhone("HomeWiFi");
        SmartPhone cellPhone = new SmartPhone("HomeWiFi");
        SmartTV livingRoomTV = new SmartTV("HomeWiFi");
        SmartTV bedRoomTV = new SmartTV("HomeWiFi");
        WirelessMouse officeMouse = new WirelessMouse();
        WirelessMouse gamingMouse = new WirelessMouse();
        IPowerable[] devices = { homePhone, cellPhone, livingRoomTV, bedRoomTV, officeMouse, gamingMouse };
        foreach (var device in devices)
        {
            device.PowerOn();
        }
        IConnectable[] connectableDevices = { homePhone, cellPhone, livingRoomTV, bedRoomTV };
        foreach (var device in connectableDevices)
        {
            device.Connect("FrancisTuttleGuest");
        }
        IRechargable[] rechargeableDevices = { homePhone, cellPhone, officeMouse, gamingMouse };
        foreach (var device in rechargeableDevices)
        {
            device.Charge();
            Console.WriteLine("Battery level: " + device.BatteryLevel + "%");
        }
    }
}
