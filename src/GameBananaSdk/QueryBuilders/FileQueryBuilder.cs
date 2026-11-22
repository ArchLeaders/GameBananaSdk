using GameBananaSdk.Endpoints;
using GameBananaSdk.Models;

namespace GameBananaSdk.QueryBuilders;

public class FileQueryBuilder : QueryBuilder<BananaFile>
{
    private readonly long _id;
    private readonly IFileApi _fileApi;

    internal FileQueryBuilder(long id, ISectionApi api, IFileApi fileApi) : base("File", id, api)
    {
        _id = id;
        _fileApi = fileApi;
    }

    public Task<Stream> Download() => _fileApi.Download(_id);
}