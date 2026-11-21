using System.Collections.Immutable;

namespace GameBananaSdk.Models;

public record BananaGame : BananaItem
{
    [JsonPropertyName("_sName")]
    public required string Name { get; set; }

    [JsonPropertyName("_sProfileUrl")]
    public string? ProfileUrl { get; set; }

    [JsonPropertyName("_sBannerUrl")]
    public string? BannerUrl { get; set; }

    [JsonPropertyName("_sIconUrl")]
    public string? IconUrl { get; set; }

    [JsonPropertyName("_aModCounts")]
    public ImmutableDictionary<string, int> ModCounts { get; set; } = [];
}