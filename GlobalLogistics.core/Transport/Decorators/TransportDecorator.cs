using GlobalLogistics.core.interfaces;

namespace GlobalLogistics.core.Transport.Decorators ;

public abstract class TransportDecorator : ITransport
{
    protected ITransport transport ; 
    public TransportDecorator(ITransport transport) => this.transport = transport ; 

    public virtual void Drive()
    {
         this.transport.Drive() ; 
    }

    public virtual double GetCost()
    {
       return  this.transport.GetCost() ; 
    }
}