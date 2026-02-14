using GlobalLogistics.core.Models;

namespace GlobalLogistics.core.Transport ; 

public class RouteBuilder
{
    private Route _route ; 

    public RouteBuilder()
    {
        _route = new Route(); 
    }

    public RouteBuilder From (string start)
    {
        
        _route.StartPoint = start; 
        return this; 
    }
    public RouteBuilder To(string to)
    {
        
        this._route.endPoint = to ; 
        return this; 
    }
     

    public RouteBuilder AddStop(string stop)
    {
        
        this._route.Stops.Add(stop) ; 
        return  this ; 

    }

    public RouteBuilder AvoidTrafic()
    {
        
        this._route.WithTrafic = false ;
        return this ;  
    }


    public Route Build()
    {
        return this._route ; 
    }

} 