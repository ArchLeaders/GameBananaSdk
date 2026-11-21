using GameBananaSdk.Models;
using Refit;

namespace GameBananaSdk.Endpoints;

public interface IUtil_Search_GamesApi
{
    [Get("/Util/Game/NameMatch")]
    Task<BananaPage<BananaGame>> Get(
        [Query(Name = "_sName")] string searchTerm,
        [Query(Name = "_nPerpage")] int? perPage = null,
        [Query(Name = "_nPage")] int? page = null
    );
}