using GameBananaSdk.Models;
using Refit;

namespace GameBananaSdk.Endpoints;

public interface IUtil_Search_ResultsApi
{
    /// <param name="searchTerm"><b>Required</b>: The search term</param>
    /// <param name="page">The page of results to get</param>
    /// <param name="pageSize">Number of results per page</param>
    /// <param name="modelName">Narrow down the search to a specific section</param>
    /// <param name="order">How to sort results</param>
    /// <param name="csvFields">Comma separated list of fields to search in</param>
    /// <param name="gameId">Search only in a specific game</param>
    /// <returns></returns>
    [Get("/Util/Search/Results")]
    Task<BananaPage<BananaObject>> Get(
        [Query(Name = "_sSearchString")] string searchTerm,
        [Query(Name = "_nPage")] int? page = null,
        [Query(Name = "_nPerpage")] int? pageSize = null,
        [Query(Name = "_sModelName")] string? modelName = null,
        [Query(Name = "_sOrder")] string? order = null,
        [Query(Name = "_csvFields")] string? csvFields = null,
        [Query(Name = "_idGameRow")] long? gameId = null);
}