using GameBananaSdk.Converters;

namespace GameBananaSdk.Models;

public record BananaModTrashInfo
{
    [JsonPropertyName("_sReason")]
    public string? Reason { get; set; }

    [JsonPropertyName("_tsTrashDate")]
    [JsonConverter(typeof(JsonTimestampToDateTimeOffset))]
    public DateTimeOffset? TrashDate { get; set; }
    
    [JsonPropertyName("_bIsNewTrashSystem")]
    public bool? IsNewTrashSystem { get; set; }
    
    [JsonPropertyName("_bIsTrashedByOwner")]
    public bool? IsTrashedByOwner { get; set; }
}