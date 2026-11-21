using System.Text.Json.Serialization;

namespace GameBananaSdk.Models;

public record BananaItem
{
    [JsonPropertyName("_idRow")]
    public long Id { get; set; }
}