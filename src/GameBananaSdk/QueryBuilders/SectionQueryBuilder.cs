using GameBananaSdk.Endpoints;
using GameBananaSdk.Models;

namespace GameBananaSdk.QueryBuilders;

/// <summary>
/// Contains endpoints for a collection of resources
/// </summary>
public class SectionQueryBuilder<T>
{
    private readonly string _modelName;
    private readonly ISectionApi _sectionApi;

    internal SectionQueryBuilder(string modelName, ISectionApi sectionApi)
    {
        _modelName = modelName;
        _sectionApi = sectionApi;
    }

    public QueryBuilder<T> this[long id] => new(_modelName, id, _sectionApi);

    public Task<BananaPage<T>> Index(
        int? page = null,
        int? pageSize = null,
        string? sort = null,
        Dictionary<string, string>? filters = null)
        => _sectionApi.Index<T>(_modelName, page, pageSize, sort, filters);

    public Task<BananaFilterConfig> ListFilterConfig()
        => _sectionApi.ListFilterConfig(_modelName);
}