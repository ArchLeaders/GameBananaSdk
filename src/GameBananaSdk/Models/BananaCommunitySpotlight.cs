using System.Collections.Immutable;

namespace GameBananaSdk.Models;

public sealed record BananaCommunitySpotlight
{
    [JsonPropertyName("_aContent")]
    public required ImmutableList<BananaItem> Content { get; set; }

    [JsonPropertyName("_aStudios")]
    public required ImmutableList<BananaItem> Studios { get; set; }

    [JsonPropertyName("_aClubs")]
    public required ImmutableList<BananaItem> Clubs { get; set; }
}