using GameBananaSdk.Models;
using Refit;

namespace GameBananaSdk.Endpoints;

public interface IUtil_Generic_DiscussionsApi
{
    [Get("/Util/Generic/Discussions")]
    Task<BananaPage<BananaDiscussion>> Get(
        [Query(Name = "_nPage")] int? page = null,
        [Query(Name = "_nPerpage")] int? pageSize = null,
        [Query(Name = "_sModelName")] string? modelName = null,
        [Query(Name = "_idStudioRow")] long? studioId = null,
        [Query(Name = "_idMemberRow")] long? memberId = null,
        [Query(Name = "_idGameRow")] long? gameId = null);
}