using System.Collections.Immutable;
using GameBananaSdk.Endpoints;
using GameBananaSdk.Models;

namespace GameBananaSdk.QueryBuilders;

public sealed class GameQueryBuilder : EntityQueryBuilder<BananaGame>
{
    private const string ModelName = "Game";

    private readonly long _id;
    private readonly IGameApi _gameApi;

    internal GameQueryBuilder(long id, IGameApi gameApi, IEntityApi entityApi) : base(ModelName, id, entityApi)
    {
        _id = id;
        _gameApi = gameApi;
    }

    public Task<BananaCommunitySpotlight> GetCommunitySpotlight()
        => _gameApi.GetCommunitySpotlight(_id);

    public Task<BananaPage<BananaSubmission>> GetSubmissionFeed(
        int? page = null, int? pageSize = null,
        string? searchTerm = null, string? sort = null,
        string? modelInclusions = null, string? modelExclusions = null,
        string? tagInclusions = null, string? tagExclusions = null)
        => _gameApi.GetSubmissionFeed(_id, page, pageSize, searchTerm, sort,
            modelInclusions, modelExclusions, tagInclusions, tagExclusions);

    public Task<ImmutableList<BananaSubmission>> GetTopSubmissions()
        => _gameApi.GetTopSubmissions(_id);
}