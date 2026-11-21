using GameBananaSdk.Endpoints;
using GameBananaSdk.Models;

namespace GameBananaSdk.QueryBuilders;

public class FileSectionQueryBuilder
{
    private readonly ISectionApi _sectionApi;

    internal FileSectionQueryBuilder(ISectionApi sectionApi)
    {
        _sectionApi = sectionApi;
    }

    public QueryBuilder<BananaFile> this[long id] => new("File", id, _sectionApi);
}