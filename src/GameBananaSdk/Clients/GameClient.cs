using GameBananaSdk.Endpoints;
using GameBananaSdk.Models;
using GameBananaSdk.QueryBuilders;

namespace GameBananaSdk.Clients;

public sealed class GameClient : EntityClient<BananaGame>
{
    private readonly IGameApi _gameApi;
    private readonly IEntityApi _entityApi;

    internal GameClient(IGameApi gameApi, IEntityApi entityApi) : base("Game", entityApi)
    {
        _gameApi = gameApi;
        _entityApi = entityApi;
    }

    public new GameQueryBuilder this[long id] => new(id, _gameApi, _entityApi);
}