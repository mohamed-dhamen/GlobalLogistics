using GlobalLogistics.core.interfaces;

namespace GlobalLogistics.core.Models ;

public class Truck : ITransport
{
    public void Drive()
    {
        Console.WriteLine("Hello I'm a Truc I'm Driving by land"); 
    }

    public double GetCost()
    {
        return 50 ; 
    }

    
}