using ExternalLib.External;

namespace StrategyPattern.Solution2.Strategies;

public class CalculateGoogleStrategy(ICalculateOfferService calculateOfferService) : ICalculateOfferStrategy
{
    public async Task CalculateOfferAsync()
    {
        decimal price = CalculateGoogleOfferPrice(2300);
        GoogleOffer googleOffer = new("Google Offer", "Description", price);
        await calculateOfferService.CalculateGoogleOfferAsync(googleOffer);
    }

    public bool CanHandle(
        Company company)
    {
        return company == Company.Google;
    }

    private static decimal CalculateGoogleOfferPrice(
        decimal price)
    {
        return price * 5;
    }
}