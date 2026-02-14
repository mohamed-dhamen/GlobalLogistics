
namespace GlobalLogistics.core.Transport ;
using GlobalLogistics.core.interfaces;
using GlobalLogistics.core.Models;
using GlobalLogistics.Core.Models;

public class DroneFactory : ITransportFactory
{
    private SuperDrone _superDrone ; 
    public DroneFactory(SuperDrone SuperDrone)
    {
        this._superDrone =  SuperDrone ; 

    }
    public Driver CreateDriver()
    {
      return  new Driver() ;
    }

    public ITransport CreateTransport()
    {
      return new DroneAdapter(_superDrone); 
    }
}