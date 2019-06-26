using Microsoft.Extensions.Configuration;

namespace MassTransitHealthCheckIssueDemo.Configuration
{
    public static class ConfigurationExtentions
    {
        public static AzureServiceBusConfiguration GetAzureServiceBusConfig(this IConfiguration configuration)
            => configuration.GetSection(nameof(AzureServiceBusConfiguration)).Get<AzureServiceBusConfiguration>();
    }
}
