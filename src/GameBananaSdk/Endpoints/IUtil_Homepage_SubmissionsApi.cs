using GameBananaSdk.Models;
using Refit;

namespace GameBananaSdk.Endpoints;

public interface IUtil_Homepage_SubmissionsApi
{
    /// <param name="page">The page of results to get</param>
    /// <param name="pageSize">Number of results per page</param>
    /// <param name="sort">How to sort results</param>
    /// <param name="filterBySubscribedGames">If provided, show submissions for the games the effective user is subscribed to</param>
    [Get("/Util/Homepage/Submissions")]
    Task<BananaPage<BananaObject>> Get(
        [Query(Name = "_nPage")] int? page = null,
        [Query(Name = "_nPerpage")] int? pageSize = null,
        [Query(Name = "_sSort")] string? sort = null,
        [Query(Name = "_bFilterBySubscribedGames")] bool filterBySubscribedGames = false);
}