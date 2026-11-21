using GameBananaSdk.Endpoints;
using GameBananaSdk.Models;

namespace GameBananaSdk.QueryBuilders;

/// <summary>
/// Contains endpoints for a collection of <see cref="BananaGame"/> objects
/// </summary>
public sealed class GameSectionQueryBuilder : SectionQueryBuilder<BananaGame>
{
    private readonly IGameApi _gameApi;
    private readonly IEntityApi _entityApi;

    internal GameSectionQueryBuilder(IGameApi gameApi, IEntityApi entityApi) : base("Game", entityApi)
    {
        _gameApi = gameApi;
        _entityApi = entityApi;
    }

    public new GameQueryBuilder this[long id] => new(id, _gameApi, _entityApi);
}