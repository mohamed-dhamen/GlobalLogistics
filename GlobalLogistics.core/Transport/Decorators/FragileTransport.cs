using GlobalLogistics.core.interfaces;
using GlobalLogistics.core.Transport.Decorators;

namespace GlobalLogistics.core.Decorators ;

public class FragileTransport : TransportDecorator
{
    public FragileTransport(ITransport transport) : base(transport)
    {
    }

    public override double GetCost()
    {
        return base.GetCost() + 50 ; 
    }

    public override void Drive()
    {
        Console.WriteLine("Fragile ! "); 
        base.Drive();
    }
}