using GameBananaSdk.Endpoints;
using GameBananaSdk.Models;
using Refit;

namespace GameBananaSdk.QueryBuilders;

public sealed class UtilSearchQueryBuilder
{
    private readonly HttpClient _client;

    internal UtilSearchQueryBuilder(HttpClient client) => _client = client;

    private IUtil_Search_ResultsApi Results
        => field ??= RestService.ForGenerated<IUtil_Search_ResultsApi>(_client, BananaJsonContext.Default);

    public IUtil_Search_GamesApi Games
        => field ??= RestService.ForGenerated<IUtil_Search_GamesApi>(_client, BananaJsonContext.Default);

    public IUtil_Search_SuggestionsApi Suggestions
        => field ??= RestService.ForGenerated<IUtil_Search_SuggestionsApi>(_client, BananaJsonContext.Default);

    public Task<BananaPage<BananaObject>> Get(string searchTerm,
        int? page = null, int? pageSize = null,
        string? modelName = null, string? order = null,
        string? csvFields = null, long? gameId = null)
        => Results.Get(searchTerm, page, pageSize, modelName, order, csvFields, gameId);
}