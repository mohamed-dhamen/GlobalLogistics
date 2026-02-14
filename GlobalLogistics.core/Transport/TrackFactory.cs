namespace GlobalLogistics.core.Transport ; 
using GlobalLogistics.core.interfaces;
using GlobalLogistics.core.Models;


public class TruckFactory : ITransportFactory
{
    public Driver CreateDriver()
    {
      return  new Driver() ;
    }

    public ITransport CreateTransport()
    {
      return  new Truck() ; 
    }
}