using ExternalLib.External;
using Microsoft.Extensions.DependencyInjection;
using StrategyPattern.Solution.Strategies;

namespace StrategyPattern.Solution;

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
        serviceCollection.AddSingleton<CalculateMicrosoftStrategy>();
        serviceCollection.AddSingleton<CalculateNetflixStrategy>();
        serviceCollection.AddSingleton<CalculateGoogleStrategy>();

        serviceCollection.AddSingleton<CalculateOfferStrategyFactory>(sp => factory =>
        {
            return factory switch
            {
                Company.Microsoft => sp.GetRequiredService<CalculateMicrosoftStrategy>(),
                Company.Netflix => sp.GetRequiredService<CalculateNetflixStrategy>(),
                Company.Google => sp.GetRequiredService<CalculateGoogleStrategy>(),
                _ => throw new InvalidOperationException("Company not supported")
            };
        });
        
        return serviceCollection;
    }
}