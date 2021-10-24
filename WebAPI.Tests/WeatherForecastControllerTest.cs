using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers;
using Xunit;

namespace WebAPI.Tests;
public class WeatherForecastControllerTest
{
    private WeatherForecastController _weatherForecastController;

    public WeatherForecastControllerTest()
    {
        _weatherForecastController = new();
    }

    [Fact]
    public void Get_WhenCalled_ReturnsOkResult()
    {
        // Arrange - this is where you would typically prepare everything for the test, in other words, prepare for testing (creating the objects and setting them up as necessary)
        // Done for us

        // Act - this is where the method we are testing is executed
        var okResult = _weatherForecastController.Get();

        // Assert - this is the final part of the test where we compare what we expect to happen with the actual result of the test method execution
        Assert.IsType<OkObjectResult>(okResult.Result);
    }

    [Fact]
    public void Get_WhenCalled_ReturnsFiveItems()
    {
        // Act
        var okResult = _weatherForecastController.Get().Result as OkObjectResult;

        // Assert
        var items = Assert.IsType<WeatherForecast[]>(okResult.Value);
        Assert.Equal(5, items.Length);
    }
}