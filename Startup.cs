using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

[assembly: FunctionsStartup(typeof(CustomException.Startup))]

namespace CustomException
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            // Register the custom exception handler
            IConfigurationRoot config = BuildConfiguration();
            ConfigureServices(builder.Services, config);
            //builder.Services.AddWebJobsExceptionHandler<CustomExceptionHandler>();
        }

        private void ConfigureServices(IServiceCollection services, IConfigurationRoot config)
        {
            
        }

        private IConfigurationRoot BuildConfiguration()
        {
            var config = new ConfigurationBuilder().SetBasePath(Environment.CurrentDirectory).AddEnvironmentVariables().Build();
            return config;
        }
    }
}