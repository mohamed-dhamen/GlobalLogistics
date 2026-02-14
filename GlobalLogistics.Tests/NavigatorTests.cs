using GlobalLogistics.core.Navigation;

namespace GlobalLogistics.Tests ; 

public class NavigatorTests
{
    
    [Fact]

    public void CalculateTime_Test_should_caulcate_as_expect()
    {
        Navigator navigator = new Navigator(new RoadStrategy()); 
        Assert.Equal(1, navigator.CalculateTime(60));
        Assert.Throws<ArgumentException>(() =>
        {
            navigator.CalculateTime(0) ; 
        });
        Assert.Throws<ArgumentNullException>(() =>
        {
           navigator.SetStrategy(null);
        });

        navigator.SetStrategy(new SeaStrategy()); 

        Assert.Equal(3 , navigator.CalculateTime(60)); 
        navigator.SetStrategy(new AirStrategy()); 

        Assert.Equal(0.3, navigator.CalculateTime(60)); 

    }
}