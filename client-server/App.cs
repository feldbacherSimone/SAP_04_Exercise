public class App
{
    private readonly string _name;
    private readonly Server _server;
    public App(string name, Server server)
    {
        _name = name;
        _server = server;
    }

    public void RequestData()
    {
        _server.GetData();
    }
}