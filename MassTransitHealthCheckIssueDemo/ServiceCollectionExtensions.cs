using MassTransit;
using MassTransit.AspNetCoreIntegration;
using MassTransit.Azure.ServiceBus.Core;
using MassTransitHealthCheckIssueDemo.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MassTransitHealthCheckIssueDemo
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMassTransitBus(this IServiceCollection serviceCollection, AzureServiceBusConfiguration config)
        {
            serviceCollection.AddMassTransit(
                provider => Bus.Factory.CreateUsingAzureServiceBus(cfg =>
                {
                    cfg.Host(config.ConnectionString, configure => { });
                }));

            return serviceCollection;
        }
    }
}
