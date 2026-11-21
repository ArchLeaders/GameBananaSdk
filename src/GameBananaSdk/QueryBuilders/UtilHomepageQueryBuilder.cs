using GameBananaSdk.Endpoints;
using Refit;

namespace GameBananaSdk.QueryBuilders;

public class UtilHomepageQueryBuilder
{
    private readonly HttpClient _client;

    internal UtilHomepageQueryBuilder(HttpClient client) => _client = client;
    
    public IUtil_Homepage_CommunitySpotlightApi CommunitySpotlight
        => field ??= RestService.ForGenerated<IUtil_Homepage_CommunitySpotlightApi>(_client, BananaJsonContext.Default);
    
    public IUtil_Homepage_FeaturesApi Features
        => field ??= RestService.ForGenerated<IUtil_Homepage_FeaturesApi>(_client, BananaJsonContext.Default);
    
    public IUtil_Homepage_SubmissionsApi Submissions
        => field ??= RestService.ForGenerated<IUtil_Homepage_SubmissionsApi>(_client, BananaJsonContext.Default);
    
    public IUtil_Homepage_TopGamesApi TopGames
        => field ??= RestService.ForGenerated<IUtil_Homepage_TopGamesApi>(_client, BananaJsonContext.Default);
}