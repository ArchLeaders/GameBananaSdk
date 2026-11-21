using GameBananaSdk.Models;
using Refit;

namespace GameBananaSdk.Endpoints;

public interface IUtil_List_FeaturedApi
{
    /// <param name="page">The page of results to get</param>
    /// <param name="pageSize">Number of results per page</param>
    /// <param name="modelName">Narrow down the search to a specific section (required if <paramref name="gameId"/> is not specified)</param>
    /// <param name="gameId">Search only in a specific game (required if <paramref name="modelName"/> is not specified)</param>
    [Get("/Util/List/Featured")]
    Task<BananaPage<BananaObject>> Get(
        [Query(Name = "_nPage")] int? page = null,
        [Query(Name = "_nPerpage")] int? pageSize = null,
        [Query(Name = "_sModelName")] string? modelName = null,
        [Query(Name = "_idGameRow")] long? gameId = null);
}