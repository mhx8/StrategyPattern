namespace ExternalLib.External;

public class CalculateOfferService : ICalculateOfferService
{
    public Task CalculateMicrosoftOfferAsync(MicrosoftOffer microsoftOffer)
    {
        Console.WriteLine("Calculating Microsoft offer...");
        return Task.CompletedTask;
    }

    public Task CalculateNetflixOfferAsync(NetflixOffer netflixOffer)
    {
        Console.WriteLine("Calculating Netflix offer...");
        return Task.CompletedTask;
    }

    public Task CalculateGoogleOfferAsync(GoogleOffer googleOffer)
    {
        Console.WriteLine("Calculating Google offer...");
        return Task.CompletedTask;
    }
}