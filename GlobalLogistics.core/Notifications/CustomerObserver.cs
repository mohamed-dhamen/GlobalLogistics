using GlobalLogistics.core.Notifications;
using GlobalLogistics.Core.Models;

namespace GlobalLogistics.Core.Notifications;

public class CustomerObserver : Person, IObserver
{
    public string LastNotification { get; private set; } = "";

    public void Update(ShipmentStatus status)
    {
        LastNotification = $"Customer {Name}: Shipment is now {status}";
        Console.WriteLine(LastNotification);
    }
}

public class WarehouseObserver : IObserver
{
    public string LastLog { get; private set; } = "";

    public void Update(ShipmentStatus status)
    {
        LastLog = $"[DB_LOG]: Shipment updated to {status} at {DateTime.Now}";
        Console.WriteLine(LastLog);
    }
}