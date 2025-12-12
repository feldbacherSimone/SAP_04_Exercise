var sensor1 = new SensorPeer();
var sensor2 = new SensorPeer();
var webApp = new WebAppPeer();

// Fake peer discovery
sensor1.DiscoverPeer(sensor2);
sensor1.DiscoverPeer(webApp);

sensor2.DiscoverPeer(sensor1);
sensor2.DiscoverPeer(webApp);

webApp.DiscoverPeer(sensor1);
webApp.DiscoverPeer(sensor2);

// Fake sensor broadcasting
Console.WriteLine("\n--- Simulation Start ---\n");

sensor1.SimulateSensorAndBroadcast();
sensor2.SimulateSensorAndBroadcast();

Console.WriteLine("\n--- Simulation End ---\n");
