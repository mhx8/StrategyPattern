using ExternalLib.External;

namespace StrategyPattern.Solution;

public class OfferCalculator(CalculateOfferStrategyFactory factory)
{
    public async Task CalculateOfferAsync(Company company)
    {
        await factory(company).CalculateOfferAsync();
    }
}