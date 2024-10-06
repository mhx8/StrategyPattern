using ExternalLib.External;

namespace StrategyPattern.Solution.Strategies;

public class CalculateGoogleStrategy(ICalculateOfferService calculateOfferService) : ICalculateOfferStrategy
{
    public async Task CalculateOfferAsync()
    {
        decimal price = CalculateGoogleOfferPrice(2300);
        GoogleOffer googleOffer = new("Google Offer", "Description", price);
        await calculateOfferService.CalculateGoogleOfferAsync(googleOffer);
    }
    
    private static decimal CalculateGoogleOfferPrice(
        decimal price)
    {
        return price * 5;
    }
}