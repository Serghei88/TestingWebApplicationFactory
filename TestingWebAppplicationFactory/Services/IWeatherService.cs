namespace TestingWebAppplicationFactory.Services;

public interface IWeatherService
{
    IEnumerable<WeatherForecast> GetWeatherForecast();
}