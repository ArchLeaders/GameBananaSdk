namespace GameBananaSdk.Models;

public record BananaTag : BananaItem
{
    [JsonPropertyName("_sRawTag")]
    public required string Tag { get; set; }
}