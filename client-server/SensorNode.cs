using System;
using System.Net.Sockets;
using System.Text;

public class SensorNode
{
    private readonly string _name;
    private readonly Server _server;

    public SensorNode(string name, Server server)
    {
        _name = name;
        _server = server;
    }

    public void Send(int value)
    {
        _server.ReceiveMoistureData(_name, value);
    }
}