using ExternalLib.External;
using Microsoft.Extensions.DependencyInjection;

namespace StrategyPattern.Solution2;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<ICalculateOfferService, CalculateOfferService>();
        serviceCollection.AddSingleton<IDataService, DataService>();
        serviceCollection.AddSingleton<OfferCalculator>();
        return serviceCollection;
    }

    public static IServiceCollection AddCalculateOfferStrategy(this IServiceCollection serviceCollection)
    {
        serviceCollection.Scan(scan => scan
            .FromAssemblyOf<Program>()
            .AddClasses(classes => classes.AssignableTo<ICalculateOfferStrategy>())
            .AsImplementedInterfaces()
            .WithTransientLifetime());

        return serviceCollection;
    }
}