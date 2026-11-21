using GameBananaSdk.Endpoints;
using GameBananaSdk.Models;

namespace GameBananaSdk.QueryBuilders;

/// <summary>
/// Contains endpoints for a collection of resources
/// </summary>
public class SectionQueryBuilder<T>
{
    private readonly string _modelName;
    private readonly IEntityApi _entityApi;

    internal SectionQueryBuilder(string modelName, IEntityApi entityApi)
    {
        _modelName = modelName;
        _entityApi = entityApi;
    }

    public QueryBuilder<T> this[long id] => new(_modelName, id, _entityApi);

    public Task<BananaPage<T>> Index(
        int? page = null,
        int? pageSize = null,
        string? sort = null,
        Dictionary<string, string>? filters = null)
        => _entityApi.Index<T>(_modelName, page, pageSize, sort, filters);

    public Task<BananaFilterConfig> ListFilterConfig()
        => _entityApi.ListFilterConfig(_modelName);
}