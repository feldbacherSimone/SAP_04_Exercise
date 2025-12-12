public class App
{
    private readonly string _name;
    private readonly Server _server;
    public App(string name, Server server)
    {
        _name = name;
        _server = server;
        _server.RegisterApp(this);
    }

    public void RequestData()
    {
        var data = _server.GetData();
        foreach (var (nodeName, value) in data)
        {
            Console.WriteLine($"[App {_name}] Moisture data from {nodeName}: {value}");
        }
    }

    public void ReceivePushNotification(string message)
    {
        Console.WriteLine($"[App {_name}] Push notification received: {message}");
    }
}