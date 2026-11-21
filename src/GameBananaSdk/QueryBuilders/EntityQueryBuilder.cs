using GameBananaSdk.Endpoints;
using GameBananaSdk.Models;

namespace GameBananaSdk.QueryBuilders;

public class EntityQueryBuilder<T> where T : BananaItem
{
    private readonly string _modelName;
    private readonly long _id;
    private readonly IEntityApi _api;

    internal EntityQueryBuilder(string modelName, long id, IEntityApi api)
    {
        _modelName = modelName;
        _id = id;
        _api = api;
    }

    public Task<T> Get() => _api.Get<T>(_modelName, _id);

    public Task<T> Get(params IEnumerable<string> properties)
        => _api.Get<T>(_modelName, _id, string.Join(',', properties));

    public Task<T> Get(string resource)
        => _api.Get<T>(_modelName, _id);
}