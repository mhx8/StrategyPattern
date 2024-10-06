using ExternalLib.External;
using Microsoft.Extensions.DependencyInjection;
using StrategyPattern.Solution2;

ServiceCollection serviceCollection = [];
serviceCollection.AddServices();
serviceCollection.AddCalculateOfferStrategy();

ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
OfferCalculator offerCalculator = serviceProvider.GetRequiredService<OfferCalculator>();


await offerCalculator.CalculateOfferAsync(Company.Google);
await offerCalculator.CalculateOfferAsync(Company.Netflix);
await offerCalculator.CalculateOfferAsync(Company.Microsoft);