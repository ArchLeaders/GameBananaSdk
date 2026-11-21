using System.Collections.Immutable;
using Refit;

namespace GameBananaSdk.Endpoints;

public interface IUtil_Config_TrashReasonsApi
{
    [Get("/Util/Config/TrashReasons")]
    public Task<ImmutableDictionary<int, string>> Get();
}