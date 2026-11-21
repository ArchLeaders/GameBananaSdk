using GameBananaSdk.Endpoints;
using GameBananaSdk.Models;
using GameBananaSdk.QueryBuilders;
using Refit;

namespace GameBananaSdk;

public sealed class GameBananaClient(string baseUrl = "https://gamebanana.com/apiv13") : IDisposable
{
    private readonly HttpClient _client = RestService.CreateHttpClient(baseUrl, new RefitSettings());
    
    private ISectionApi SectionApi => field ??= RestService.ForGenerated<ISectionApi>(_client, SdkJsonContext.Default);

    private IGameApi GameApi => field ??= RestService.ForGenerated<IGameApi>(_client, SdkJsonContext.Default);
    
    public GameSectionQueryBuilder Games => field ??= new GameSectionQueryBuilder(GameApi, SectionApi);
    
    public SectionQueryBuilder<BananaMod> Mods => field ??= new SectionQueryBuilder<BananaMod>("Mod", SectionApi);
    
    public SectionQueryBuilder<BananaObject> Query(string modelName) => new(modelName, SectionApi);
    
    public SectionQueryBuilder<T> QueryFor<T>(string modelName) => new(modelName, SectionApi);

    public void Dispose()
    {
        _client.Dispose();
    }
}