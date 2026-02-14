namespace GlobalLogistics.Tests ; 
using GlobalLogistics.core.Singletons;

public class HeadquartersTest
{
    
[Fact]
public void HeadquartersTest_shouldcreate_one_instance(){

    var headquarters1 = Headquarters.Instance ; 
    var headquarters2 = Headquarters.Instance ; 

    Assert.Same(headquarters1, headquarters2); 
}
}