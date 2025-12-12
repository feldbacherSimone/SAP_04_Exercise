public class Server
{
    private List<(string nodeName, int data)> moistureData = new();
    public bool ReceiveMoistureData(string nodeName, List<int> values)
    {
        Console.WriteLine($"[Server] Moisture data received from {nodeName}: {values.Count} entries.");
        foreach (var value in values)
        {
            moistureData.Add((nodeName, value));
        }
        return true;
    }
    public List<(string nodeName, int data)> GetData()
    {
        Console.WriteLine("[Server] Data requested.");
        return moistureData;
    }
}