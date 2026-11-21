using GameBananaSdk.Clients;
using GameBananaSdk.Endpoints;
using GameBananaSdk.Models;
using Refit;

namespace GameBananaSdk;

public sealed class GameBananaClient : IDisposable
{
    private readonly HttpClient _client = RestService.CreateHttpClient("https://gamebanana.com/apiv11", new RefitSettings());
    
    private IEntityApi EntityApi => field ??= RestService.ForGenerated<IEntityApi>(_client, SdkJsonContext.Default);

    private IGameApi GameApi => field ??= RestService.ForGenerated<IGameApi>(_client, SdkJsonContext.Default);
    
    public GameClient Games => field ??= new GameClient(GameApi, EntityApi);
    
    public EntityClient<BananaMod> Mods => field ??= new EntityClient<BananaMod>("Mod", EntityApi);

    public void Dispose()
    {
        _client.Dispose();
    }
}