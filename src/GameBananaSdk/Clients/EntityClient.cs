using GameBananaSdk.Endpoints;
using GameBananaSdk.Models;
using GameBananaSdk.QueryBuilders;

namespace GameBananaSdk.Clients;

public class EntityClient<T> where T : BananaItem
{
    private readonly string _modelName;
    private readonly IEntityApi _entityApi;

    internal EntityClient(string modelName, IEntityApi entityApi)
    {
        _modelName = modelName;
        _entityApi = entityApi;
    }

    public EntityQueryBuilder<T> this[long id] => new(_modelName, id, _entityApi);

    public Task<BananaPage<T>> Index(
        int? page = null,
        int? pageSize = null,
        string? sort = null,
        Dictionary<string, string>? filters = null)
        => _entityApi.Index<T>(_modelName, page, pageSize, sort, filters);

    public Task<BananaFilterConfig> ListFilterConfig()
        => _entityApi.ListFilterConfig(_modelName);
}