using GameBananaSdk.Endpoints;
using GameBananaSdk.Models;

namespace GameBananaSdk.QueryBuilders;

/// <summary>
/// Contains endpoints for a collection of <see cref="BananaGame"/> objects
/// </summary>
public sealed class GameSectionQueryBuilder : SectionQueryBuilder<BananaGame>
{
    private readonly IGameApi _gameApi;
    private readonly ISectionApi _sectionApi;

    internal GameSectionQueryBuilder(IGameApi gameApi, ISectionApi sectionApi) : base("Game", sectionApi)
    {
        _gameApi = gameApi;
        _sectionApi = sectionApi;
    }

    public new GameQueryBuilder this[long id] => new(id, _gameApi, _sectionApi);
}