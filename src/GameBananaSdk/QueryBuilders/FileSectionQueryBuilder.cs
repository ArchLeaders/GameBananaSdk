using GameBananaSdk.Endpoints;

namespace GameBananaSdk.QueryBuilders;

public class FileSectionQueryBuilder
{
    private readonly ISectionApi _sectionApi;
    private readonly IFileApi _fileApi;

    internal FileSectionQueryBuilder(ISectionApi sectionApi, IFileApi fileApi)
    {
        _sectionApi = sectionApi;
        _fileApi = fileApi;
    }

    public FileQueryBuilder this[long id] => new(id, _sectionApi, _fileApi);
}