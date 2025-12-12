using System;
using System.Net.Sockets;
using System.Text;

public class SensorNode
{
    private readonly string _name;
    private readonly Server _server;

    private List<int> _dataBuffer = new();

    public SensorNode(string name, Server server)
    {
        _name = name;
        _server = server;
    }

    public void Send()
    {
        var ok = _server.ReceiveMoistureData(_name, _dataBuffer);
        if (ok) { _dataBuffer.Clear(); }
    }

    public void PollSensor()
    {
        // Simulate sensor polling
        Random rand = new Random();
        int moistureValue = rand.Next(0, 1000);
        _dataBuffer.Add(moistureValue);
        //Send(moistureValue);
    }
}