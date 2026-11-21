using System.Collections.Immutable;
using GameBananaSdk.Models;
using Refit;

namespace GameBananaSdk.Endpoints;

public interface IUtil_Homepage_FeaturesApi
{
    [Get("/Util/Homepage/Features")]
    Task<ImmutableList<BananaObject>> Get();
}