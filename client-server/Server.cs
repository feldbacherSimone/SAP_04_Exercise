public class Server
{
    public void ReceiveMoistureData(string nodeName, int data)
    {
        Console.WriteLine($"[Server] Moisture data received from {nodeName}: {data}");
    }

    public void GetData()
    {
        Console.WriteLine("[Server] Data requested.");
    }
}