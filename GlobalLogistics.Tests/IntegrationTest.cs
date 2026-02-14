namespace GlobalLogistics.Tests;

using GlobalLogistics.core.Decorators;
using GlobalLogistics.core.interfaces;
using GlobalLogistics.core.Models;
using GlobalLogistics.core.Navigation;
using GlobalLogistics.core.Singletons;
using GlobalLogistics.core.Transport;
using GlobalLogistics.Core.Models;
using GlobalLogistics.Core.Notifications;
using Xunit;

public class IntegrationTest
{
    [Fact]
    public void The_Global_Logistics_System_Works()
    {
        // 1. SINGLETON: Open Headquarters
        Headquarters hq = Headquarters.Instance;
        hq.TotalShipments++;
        Assert.Equal(1, hq.TotalShipments);

        // 2. FACTORY & ADAPTER: Deploy a Drone
        SuperDrone alienTech = new SuperDrone();
        ITransportFactory factory = new DroneFactory(alienTech);
        ITransport drone = factory.CreateTransport();

        // 3. DECORATOR: Make it Fragile (Cost: 1000 + 50)
        ITransport fragileDrone = new FragileTransport(drone);
        Assert.Equal(1050, fragileDrone.GetCost());

        // 4. STRATEGY: Calculate ETA via Air (Speed: 200)
        Navigator navigator = new Navigator(new AirStrategy());
        double eta = navigator.CalculateTime(1000); // 1000km / 200km/h = 5 hours
        Assert.Equal(5, eta);

        // 5. OBSERVER: Notify the Customer
        Shipment shipment = new Shipment();
        CustomerObserver customer = new CustomerObserver { Name = "John Doe" };
        
        shipment.Attach(customer);
        shipment.Status = ShipmentStatus.OnWay; // Triggers update

        // ASSERT: Did the customer get the message?
        Assert.Contains("OnWay", customer.LastNotification);
    }
}