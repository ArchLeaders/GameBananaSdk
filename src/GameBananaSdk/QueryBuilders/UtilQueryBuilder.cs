namespace GameBananaSdk.QueryBuilders;

public class UtilQueryBuilder
{
    private readonly HttpClient _client;

    internal UtilQueryBuilder(HttpClient client) => _client = client;

    public UtilConfigQueryBuilder Config => field ??= new UtilConfigQueryBuilder(_client);

    public UtilGenericQueryBuilder Generic => field ??= new UtilGenericQueryBuilder(_client);

    public UtilHomepageQueryBuilder Homepage => field ??= new UtilHomepageQueryBuilder(_client);

    public UtilListQueryBuilder List => field ??= new UtilListQueryBuilder(_client);

    public UtilSearchQueryBuilder Search => field ??= new UtilSearchQueryBuilder(_client);
}