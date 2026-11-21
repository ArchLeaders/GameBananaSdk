using GameBananaSdk.Endpoints;
using GameBananaSdk.Models;
using GameBananaSdk.QueryBuilders;
using Refit;

namespace GameBananaSdk;

public sealed class GameBananaClient(string baseUrl = "https://gamebanana.com/apiv13") : IDisposable
{
    private readonly HttpClient _client = RestService.CreateHttpClient(baseUrl, new RefitSettings());
    
    private IEntityApi EntityApi => field ??= RestService.ForGenerated<IEntityApi>(_client, SdkJsonContext.Default);

    private IGameApi GameApi => field ??= RestService.ForGenerated<IGameApi>(_client, SdkJsonContext.Default);
    
    public GameSectionQueryBuilder Games => field ??= new GameSectionQueryBuilder(GameApi, EntityApi);
    
    public SectionQueryBuilder<BananaMod> Mods => field ??= new SectionQueryBuilder<BananaMod>("Mod", EntityApi);
    
    public SectionQueryBuilder<BananaObject> Query(string modelName) => new(modelName, EntityApi);
    
    public SectionQueryBuilder<T> QueryFor<T>(string modelName) => new(modelName, EntityApi);

    public void Dispose()
    {
        _client.Dispose();
    }
}