namespace GlobalLogistics.core.Models; 

public class Route
{
    public string? StartPoint {get ; set ; }  
    public string? endPoint {get ; set ; }
    public List<string> Stops = new List<string>(); 
    public bool WithTrafic  {get ; set; }
}