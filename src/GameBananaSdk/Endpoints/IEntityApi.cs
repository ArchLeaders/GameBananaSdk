using GameBananaSdk.Models;
using Refit;

namespace GameBananaSdk.Endpoints;

public interface IEntityApi
{
    [Get("/{modelName}/{id}")]
    Task<T> Get<T>(
        string modelName,
        long id,
        [Query(Name = "_csvProperties")] string? properties = "@gbprofile"
    ) where T : BananaItem;
    
    [Get("/{modelName}/{id}/ProfilePage")]
    Task<T> GetProfilePage<T>(string modelName, long id) where T : BananaItem;
    
    [Get("/{modelName}/Index")]
    Task<BananaPage<T>> Index<T>(string modelName,
        [Query(Name = "_nPage")] int? page = null,
        [Query(Name = "_nPerpage")] int? pageSize = null,
        [Query(Name = "_sSort")] string? sort = null,
        [Query] Dictionary<string, string>? filters = null)
        where T : BananaItem;
    
    [Get("/{modelName}/ListFilterConfig")]
    Task<BananaFilterConfig> ListFilterConfig(string modelName);
}