using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TestingWebAppplicationFactory.Services;

namespace Test;

public class MyTestApp : WebApplicationFactory<Program>
{
    protected override IHost CreateHost(IHostBuilder builder)
    {
        builder.ConfigureServices(services =>
        {
            services.AddScoped<IWeatherService, TestWeatherService>();
        });
        return base.CreateHost(builder);
    }
}