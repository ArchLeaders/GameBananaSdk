using System.Collections.Immutable;
using Refit;

namespace GameBananaSdk.Endpoints;

public interface IUtil_Search_TagsApi
{
    [Get("/Util/Generic/Tags")]
    Task<ImmutableList<string>> Get(
        [Query(Name = "_sTag")] string searchTerm,
        [Query(Name = "_nPage")] int? page = null,
        [Query(Name = "_nPerpage")] int? pageSize = null,
        [Query(Name = "_idGameRow")] long? gameId = null);
}