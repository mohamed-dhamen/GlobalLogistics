using GlobalLogistics.Core.Models;

namespace GlobalLogistics.core.Models ; 

public class Driver : Person
{


    

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine("I'm a driver "); 

    }


    
}