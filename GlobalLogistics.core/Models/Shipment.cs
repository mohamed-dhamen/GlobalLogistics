using GlobalLogistics.core.Notifications;

namespace GlobalLogistics.Core.Models;
public enum ShipmentStatus
{
    InCharging,
    ReadyToTrip,
    OnWay,
    Delivered
}

public class Shipment 
{
    // 1. Private backing field
    private ShipmentStatus _status; 

    // 2. List of Subscribers
    private List<IObserver> _observers = new List<IObserver>();

    // 3. The Property that triggers the magic
    public ShipmentStatus Status
    {
        get => _status;
        set 
        { 
            // Only notify if the status is DIFFERENT
            if (_status != value)
            {
                _status = value;
                Notify(_status);
            }
        }
    } 

    // 4. Methods to manage subscribers
    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    private void Notify(ShipmentStatus status)
    {
        Console.WriteLine($"[Shipment]: Status changed to {status}. Notifying {_observers.Count} observers...");
        _observers.ForEach(o => o.Update(status)); 
    }
}