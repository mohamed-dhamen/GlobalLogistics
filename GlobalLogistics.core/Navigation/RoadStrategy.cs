using GlobalLogistics.core.interfaces;

namespace GlobalLogistics.core.Navigation ; 

public class RoadStrategy : IRouteStrategy
{

    public double CalculateTime(double distance)
    {
            if(distance ==0 ) throw new ArgumentException("argument exception the distance should sup a 0"); 
            else return distance /60 ; 

    }      
    
}