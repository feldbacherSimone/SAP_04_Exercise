using System.IO;

public class ProgramTest
{
    public static void Main(string[] args)
    {
        Server server = new Server();
        App app = new App("Handy", server);
        SensorNode node1 = new SensorNode("node1", server);
        SensorNode node2 = new SensorNode("node2", server);

        node1.Send(550);
        node2.Send(620);

        app.RequestData();
    }
}