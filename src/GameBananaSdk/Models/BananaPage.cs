using System.Collections.Immutable;
using System.Text.Json.Serialization;

namespace GameBananaSdk.Models;

public record BananaPage<TRecord> where TRecord : BananaItem
{
    [JsonPropertyName("_aMetadata")]
    public required BananaPageMetadata Metadata { get; set; }
    
    [JsonPropertyName("_aRecords")]
    public required ImmutableList<TRecord> Records { get; set; }
}