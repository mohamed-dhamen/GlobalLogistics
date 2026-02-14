
namespace GlobalLogistics.core.Transport ;
using GlobalLogistics.core.interfaces;
using GlobalLogistics.core.Models;



public class ShipFcatory : ITransportFactory
{
    public Driver CreateDriver()
    {
      return  new Driver() ;
    }

    public ITransport CreateTransport()
    {
      return  new Ship() ; 
    }
}