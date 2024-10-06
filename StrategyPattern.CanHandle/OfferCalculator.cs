using ExternalLib.External;

namespace StrategyPattern.Solution2;

public class OfferCalculator(
    IEnumerable<ICalculateOfferStrategy> calculateOfferStrategies)
{
    public async Task CalculateOfferAsync(
        Company company)
    {
        if (!calculateOfferStrategies.Any(
                strategy => strategy.CanHandle(company)))
        {
            throw new InvalidOperationException("No strategy found for the given company.");
        }

        foreach (ICalculateOfferStrategy calculateOfferStrategy in calculateOfferStrategies
                     .Where(
                         strategy => strategy.CanHandle(company)))
        {
            await calculateOfferStrategy.CalculateOfferAsync();
        }
    }
}