using System.Collections.Immutable;

namespace GameBananaSdk.Models;

public sealed record BananaFilterConfig
{
    [JsonPropertyName("_aSorts")]
    public required ImmutableList<BananaSort> Sorts { get; set; }
    
    [JsonPropertyName("_aFilters")]
    public required ImmutableList<BananaFilter> Filters { get; set; }
    
    [JsonPropertyName("_aPresets")]
    public required ImmutableList<BananaPreset> Presets { get; set; }
}

public record BananaSort
{
    [JsonPropertyName("_sAlias")]
    public required string Alias { get; set; }
    
    [JsonPropertyName("_sTitle")]
    public required string Title { get; set; }
}

public record BananaFilterOption
{
    [JsonPropertyName("_sAlias")]
    public required string Alias { get; set; }
    
    [JsonPropertyName("_sTitle")]
    public required string Title { get; set; }
}

public record BananaFilter
{
    [JsonPropertyName("_sType")]
    public required string Type { get; set; }
    
    [JsonPropertyName("_sTitle")]
    public string? Title { get; set; }

    [JsonPropertyName("_aOptions")]
    public ImmutableList<BananaFilterOption> Options { get; set; } = [];
    
    [JsonPropertyName("_sAlias")]
    public required string Alias { get; set; }
}

public record BananaPreset
{
    [JsonPropertyName("_sTitle")]
    public required string Title { get; set; }
    
    [JsonPropertyName("_sIconClasses")]
    public required string IconClasses { get; set; }
    
    [JsonPropertyName("_aParams")]
    public required ImmutableDictionary<string, string> Parameters { get; set; }
}
