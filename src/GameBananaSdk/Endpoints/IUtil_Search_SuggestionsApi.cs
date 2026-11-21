using System.Collections.Immutable;
using Refit;

namespace GameBananaSdk.Endpoints;

public interface IUtil_Search_SuggestionsApi
{
    [Get("/Util/Search/Suggestions?_sSearchString={searchString}&_sModelName={modelName}&_idGameRow={gameId}")]
    Task<ImmutableDictionary<int, string>> Get(string searchString, string modelName, ulong? gameId = null);
}