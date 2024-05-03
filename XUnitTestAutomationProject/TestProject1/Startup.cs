using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Runtime.Intrinsics.Arm;

namespace TestProject1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var config = services.BuildServiceProvider().GetService<IConfiguration>();

            var GetConfigData = config.Get<ConfigData>();

            services
                .AddSingleton<IEmployee, Employee>(x => new Employee(configData: GetConfigData))
                .AddSingleton<ILocation, Location>();


            // Set the service provider in the service locator
            ServiceLocator.SetProvider(services.BuildServiceProvider());
        }

        public void ConfigureHost(IHostBuilder hostBuilder)
        {
            var env = Environment.GetEnvironmentVariable("API_Environment");

            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            hostBuilder.ConfigureHostConfiguration(builder => builder.AddConfiguration(config));
        }
    }
}
