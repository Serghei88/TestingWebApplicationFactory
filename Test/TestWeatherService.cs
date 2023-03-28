using TestingWebAppplicationFactory;
using TestingWebAppplicationFactory.Services;

namespace Test;

public class TestWeatherService : IWeatherService
{
    public IEnumerable<WeatherForecast> GetWeatherForecast()
    {
        return new[]
        {
            new WeatherForecast
            {
                Summary = "test"
            }
        };
    }
}