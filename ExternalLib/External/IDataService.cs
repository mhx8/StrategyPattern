namespace ExternalLib.External;

public interface IDataService
{
    Task PrepareMicrosoftDataAsync();
    
    Task PrepareNetflixDataAsync();
}