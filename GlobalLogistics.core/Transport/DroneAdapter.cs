using GlobalLogistics.core.interfaces;
using GlobalLogistics.core.Models;

namespace GlobalLogistics.core.Transport ;

public class DroneAdapter : ITransport
{

    private SuperDrone _superDrone ; 

    public DroneAdapter(SuperDrone superDron)
    {
        
        this._superDrone = superDron ;
    }

    public void Drive()
    {
       _superDrone.Peep() ; 
       _superDrone.Start();
       _superDrone.Fly() ; 
    }

    public double GetCost()
    {
        return 1000 ; 
    }
}