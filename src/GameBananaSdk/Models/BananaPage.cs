using System.Collections.Immutable;

namespace GameBananaSdk.Models;

public record BananaPage<TRecord>
{
    [JsonPropertyName("_aMetadata")]
    public required BananaPageMetadata Metadata { get; set; }
    
    [JsonPropertyName("_aRecords")]
    public required ImmutableList<TRecord> Records { get; set; }
}