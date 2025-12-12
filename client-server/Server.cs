public class Server
{
    private List<(string nodeName, int data)> moistureData = new();
    private List<App> registeredApps = new();
    private int Threshold = 300;

    public void RegisterApp(App app)
    {
        registeredApps.Add(app);
    }
    public bool ReceiveMoistureData(string nodeName, List<int> values)
    {
        Console.WriteLine($"[Server] Moisture data received from {nodeName}: {values.Count} entries.");
        foreach (var value in values)
        {
            moistureData.Add((nodeName, value));
            if (value > Threshold)
            {
                foreach (var app in registeredApps)
                {
                    app.ReceivePushNotification($"Moisture level {value} from {nodeName} is above threshold {Threshold}.");
                }
            }
        }
        return true;
    }
    public List<(string nodeName, int data)> GetData()
    {
        Console.WriteLine("[Server] Data requested.");
        return moistureData;
    }
}