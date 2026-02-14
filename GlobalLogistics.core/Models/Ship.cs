using GlobalLogistics.core.interfaces;

namespace GlobalLogistics.core.Models ;

public class Ship : ITransport
{
    public void Drive()
    {
       Console.WriteLine("Hello I'm a ship I'm shiping on the Sea") ; 
    }

    public double GetCost()
    {
        return 500 ; 

    }
}