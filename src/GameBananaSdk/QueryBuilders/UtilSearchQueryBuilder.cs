using GameBananaSdk.Endpoints;
using Refit;

namespace GameBananaSdk.QueryBuilders;

public sealed class UtilSearchQueryBuilder
{
    private readonly HttpClient _client;

    internal UtilSearchQueryBuilder(HttpClient client) => _client = client;
    
    public IUtil_Search_GamesApi Games
        => field ??= RestService.ForGenerated<IUtil_Search_GamesApi>(_client, SdkJsonContext.Default);

    public IUtil_Search_ResultsApi Results
        => field ??= RestService.ForGenerated<IUtil_Search_ResultsApi>(_client, SdkJsonContext.Default);

    public IUtil_Search_SuggestionsApi Suggestions
        => field ??= RestService.ForGenerated<IUtil_Search_SuggestionsApi>(_client, SdkJsonContext.Default);
}