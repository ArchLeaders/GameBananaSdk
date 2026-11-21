using GameBananaSdk.Endpoints;

namespace GameBananaSdk.QueryBuilders;

/// <summary>
/// Contains endpoints for an identified resource
/// </summary>
public class QueryBuilder<T>
{
    private readonly string _modelName;
    private readonly long _id;
    private readonly ISectionApi _api;

    internal QueryBuilder(string modelName, long id, ISectionApi api)
    {
        _modelName = modelName;
        _id = id;
        _api = api;
    }

    public Task<T> Get() => _api.Get<T>(_modelName, _id);

    public Task<T> Get(params IEnumerable<string> properties)
        => _api.Get<T>(_modelName, _id, string.Join(',', properties));
}