interface IConnectable
{
    string Ssid { get; }
    void Connect(string newtorkName);
    void Disconnect();
}