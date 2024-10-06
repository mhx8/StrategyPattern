using ExternalLib.External;

namespace StrategyPattern.Solution.Strategies;

public class CalculateMicrosoftStrategy(
    IDataService dataService,
    ICalculateOfferService calculateOfferService) : ICalculateOfferStrategy
{
    public async Task CalculateOfferAsync()
    {
        await dataService.PrepareMicrosoftDataAsync();
        string offerName = $"Microsoft Offer {DateTime.Now:d}";
        MicrosoftOffer microsoftOffer = new(offerName, "Description", 1000);

        await calculateOfferService.CalculateMicrosoftOfferAsync(microsoftOffer);
    }
}