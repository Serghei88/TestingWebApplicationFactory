using System.Text.Json;
using TestingWebAppplicationFactory;
using Xunit;

namespace Test;

public class TestApp
{
    [Fact]
    public async Task Test()
    {
        var app = new MyTestApp();
        var httpClient = app.CreateClient();

        var response = await httpClient.GetAsync("/WeatherForecast");
        var jsonString = await response.Content.ReadAsStringAsync();

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        var objectResponse =
            JsonSerializer.Deserialize<IEnumerable<WeatherForecast>>(jsonString, options).ToList();
        response.EnsureSuccessStatusCode();
        Assert.True(objectResponse.Count() == 1);
        Assert.True(objectResponse[0].Summary == "test");
    }
}