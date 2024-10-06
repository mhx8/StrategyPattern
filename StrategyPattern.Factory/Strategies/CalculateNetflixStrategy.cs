using ExternalLib.External;

namespace StrategyPattern.Solution.Strategies;

public class CalculateNetflixStrategy(
    IDataService dataService,
    ICalculateOfferService calculateOfferService) : ICalculateOfferStrategy
{
    public async Task CalculateOfferAsync()
    {
        await dataService.PrepareNetflixDataAsync();
        NetflixOffer netflixOffer = new("Netflix Offer", "Description", 2000);

        await calculateOfferService.CalculateNetflixOfferAsync(netflixOffer);
    }
}