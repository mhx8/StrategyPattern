using ExternalLib.External;

namespace StrategyPattern.Solution2;

public interface ICalculateOfferStrategy
{
    Task CalculateOfferAsync();
    
    bool CanHandle(Company company);
}