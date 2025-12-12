using System.IO;

public class ProgramTest
{
    public static void Main(string[] args)
    {
        Server server = new Server();
        App app = new App("Handy", server);
        
        SensorNode node1 = new SensorNode("node1", server);
        SensorNode node2 = new SensorNode("node2", server);

        node1.PollSensor();
        node2.PollSensor();
        node1.Send();
        node2.Send();

        app.RequestData();
    }
}