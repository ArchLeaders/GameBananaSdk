using System.Collections.Immutable;
using GameBananaSdk.Models;
using Refit;

namespace GameBananaSdk.Endpoints;

public interface IGameApi
{
    [Get("/Game/{id}/Subfeed")]
    Task<BananaPage<BananaObject>> GetSubmissionFeed(
        long id,
        [Query(Name = "_nPage")] int? page = null,
        [Query(Name = "_nPerpage")] int? pageSize = null,
        [Query(Name = "_sName")] string? searchTerm = null,
        [Query(Name = "_sSort")] string? sort = null,
        [Query(Name = "_csvModelInclusions")] string? modelInclusions = null,
        [Query(Name = "_csvModelExclusions")] string? modelExclusions = null,
        [Query(Name = "_csvTagInclusions")] string? tagInclusions = null,
        [Query(Name = "_csvTagExclusions")] string? tagExclusions = null);

    [Get("/Game/{id}/TopSubs")]
    Task<ImmutableList<BananaObject>> GetTopSubmissions(long id);

    [Get("/Game/{id}/CommunitySpotlight")]
    Task<BananaCommunitySpotlight> GetCommunitySpotlight(long id);
}