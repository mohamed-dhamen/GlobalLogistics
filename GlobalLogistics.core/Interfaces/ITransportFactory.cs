using GlobalLogistics.core.Models;

namespace GlobalLogistics.core.interfaces ; 

public interface ITransportFactory
{
    
    ITransport CreateTransport() ; 
    Driver CreateDriver() ; 

}