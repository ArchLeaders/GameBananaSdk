using GameBananaSdk.Models;
using Refit;

namespace GameBananaSdk.Endpoints;

public interface IUtil_Homepage_CommunitySpotlightApi
{
    [Get("/Util/Homepage/CommunitySpotlight")]
    Task<BananaCommunitySpotlight> Get();
}