using System.ComponentModel;

namespace GlobalLogistics.core.Singletons ; 

public class Headquarters
{
     private static Lazy<Headquarters> headquarters = new Lazy<Headquarters>(() =>
     {
        return  new Headquarters(); 
        
     }); 
    public static Headquarters Instance  {get => headquarters .Value ; }

     // 2. Global Stats
    public int TotalShipments { get; set; } = 0;

    private Headquarters()
    {
         Console.WriteLine("Headquarters established.");
    } 
}