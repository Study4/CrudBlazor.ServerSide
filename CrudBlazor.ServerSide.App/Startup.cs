using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;
using CrudBlazor.ServerSide.App.Services;
using Microsoft.EntityFrameworkCore;
using CrudBlazor.ServerSide.App.Infrastructures;
using Microsoft.Extensions.Configuration;

namespace CrudBlazor.ServerSide.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Since Blazor is running on the server, we can use an application service
            // to read the forecast data.
            services.AddSingleton<WeatherForecastService>();
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
