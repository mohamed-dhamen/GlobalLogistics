using GlobalLogistics.core.interfaces;
using GlobalLogistics.core.Transport.Decorators;

namespace GlobalLogistics.core.Decorators ;

public class RefrigeratedTransport : TransportDecorator
{
    public RefrigeratedTransport(ITransport transport) : base(transport)
    {
    }
    public override double GetCost()
    {
        return base.GetCost() + 200 ; 
    }

    public override void Drive()
    {
        Console.WriteLine("❄️ Cooling");
        base.Drive();
    }
}