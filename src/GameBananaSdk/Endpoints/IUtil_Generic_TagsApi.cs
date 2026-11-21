using GameBananaSdk.Models;
using Refit;

namespace GameBananaSdk.Endpoints;

public interface IUtil_Generic_TagsApi
{
    [Get("/Util/Generic/Tags")]
    Task<BananaPage<BananaTag>> Get(
        [Query(Name = "_sTag")] string searchTerm,
        [Query(Name = "_nPage")] int? page = null,
        [Query(Name = "_nPerpage")] int? pageSize = null,
        [Query(Name = "_idGameRow")] long? gameId = null);
}