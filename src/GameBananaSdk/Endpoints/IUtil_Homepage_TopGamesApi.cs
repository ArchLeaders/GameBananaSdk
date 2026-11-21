using System.Collections.Immutable;
using GameBananaSdk.Models;
using Refit;

namespace GameBananaSdk.Endpoints;

public interface IUtil_Homepage_TopGamesApi
{
    [Get("/Util/Homepage/TopGames")]
    Task<ImmutableDictionary<string, ImmutableList<BananaGame>>> Get();
}