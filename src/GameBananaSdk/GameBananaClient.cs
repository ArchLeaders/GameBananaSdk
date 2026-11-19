using Refit;

namespace GameBananaSdk;

public sealed class GameBananaClient(string baseUrl = "https://gamebanana.com/apiv11") : IDisposable
{
    private readonly HttpClient _client = RestService.CreateHttpClient(baseUrl, new RefitSettings());

    public void Dispose()
    {
        _client.Dispose();
    }
}