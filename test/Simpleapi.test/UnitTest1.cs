using Xunit;
using Simpleapi.Controllers;

namespace Simpleapi.test;

public class UnitTest1
{
    WeatherForecastController controller = new WeatherForecastController();
    [Fact]
    public void GetReturnMyName()
    {
        var returnValue = controller.Get();
        Assert.Equal("Byron",returnValue.ToString());
    }
}