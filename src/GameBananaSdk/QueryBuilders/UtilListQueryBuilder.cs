using GameBananaSdk.Endpoints;
using Refit;

namespace GameBananaSdk.QueryBuilders;

public class UtilListQueryBuilder
{
    private readonly HttpClient _client;

    internal UtilListQueryBuilder(HttpClient client) => _client = client;
    
    public IUtil_List_FeaturedApi Featured
        => field ??= RestService.ForGenerated<IUtil_List_FeaturedApi>(_client, SdkJsonContext.Default);
}