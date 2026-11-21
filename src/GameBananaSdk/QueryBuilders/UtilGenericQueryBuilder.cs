using GameBananaSdk.Endpoints;
using Refit;

namespace GameBananaSdk.QueryBuilders;

public class UtilGenericQueryBuilder
{
    private readonly HttpClient _client;

    internal UtilGenericQueryBuilder(HttpClient client) => _client = client;
    
    public IUtil_Generic_DiscussionsApi Discussions
        => field ??= RestService.ForGenerated<IUtil_Generic_DiscussionsApi>(_client, BananaJsonContext.Default);
    
    public IUtil_Generic_TagsApi Tags
        => field ??= RestService.ForGenerated<IUtil_Generic_TagsApi>(_client, BananaJsonContext.Default);
}