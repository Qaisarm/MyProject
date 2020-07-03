using Microsoft.Extensions.Logging;
using MyProject;
using MyProject.Controllers;
using System.Collections.Generic;
using Xunit;

namespace Test
{
    public class WeatherForecastTests
    {
        WeatherForecastController _controller;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastTests()
        {
            _controller = new WeatherForecastController(_logger);
        }
        [Fact]
        public void Check_WeatherForecastReturnType()
        {
            var responce = _controller.Get();
            Assert.IsAssignableFrom<IEnumerable<WeatherForecast>>(responce);
     
        }

        [Fact]
        public void Check_WeatherForecastDataIsNotNull()
        {
            var responce = _controller.Get();
            Assert.NotNull(responce);
        }
    }
       

}

