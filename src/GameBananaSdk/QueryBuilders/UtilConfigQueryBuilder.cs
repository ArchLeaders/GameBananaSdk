using GameBananaSdk.Endpoints;
using Refit;

namespace GameBananaSdk.QueryBuilders;

public sealed class UtilConfigQueryBuilder
{
    private readonly HttpClient _client;

    internal UtilConfigQueryBuilder(HttpClient client) => _client = client;

    public IUtil_Config_TrashReasonsApi TrashReasons
        => field ??= RestService.ForGenerated<IUtil_Config_TrashReasonsApi>(_client, SdkJsonContext.Default);
}