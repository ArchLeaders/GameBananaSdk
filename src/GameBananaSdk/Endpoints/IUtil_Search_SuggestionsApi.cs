using System.Collections.Immutable;
using Refit;

namespace GameBananaSdk.Endpoints;

public interface IUtil_Search_SuggestionsApi
{
    [Get("/Util/Search/Suggestions")]
    Task<ImmutableList<string>> Get(
        [Query(Name = "_sSearchString")] string searchTerm,
        [Query(Name = "_sModelName")] string modelName,
        [Query(Name = "_idGameRow")] ulong? gameId = null);
}