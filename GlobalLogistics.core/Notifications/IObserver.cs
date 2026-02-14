using GlobalLogistics.core.Models;
using GlobalLogistics.Core.Models;

namespace GlobalLogistics.core.Notifications ; 

public interface IObserver
{
    // C# convention: Methods should be PascalCase
    void Update(ShipmentStatus status); 
}