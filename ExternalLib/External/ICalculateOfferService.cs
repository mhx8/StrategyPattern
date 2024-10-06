namespace ExternalLib.External;

public interface ICalculateOfferService
{
    Task CalculateMicrosoftOfferAsync(
        MicrosoftOffer microsoftOffer);

    Task CalculateNetflixOfferAsync(
        NetflixOffer netflixOffer);

    Task CalculateGoogleOfferAsync(
        GoogleOffer googleOffer);
}