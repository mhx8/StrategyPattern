namespace ExternalLib.External;

public class DataService : IDataService
{
    public Task PrepareMicrosoftDataAsync()
    {
        return Task.CompletedTask;
    }

    public Task PrepareNetflixDataAsync()
    {
        return Task.CompletedTask; }
}