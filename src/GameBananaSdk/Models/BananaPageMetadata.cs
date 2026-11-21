namespace GameBananaSdk.Models;

public record BananaPageMetadata
{
    [JsonPropertyName("_nRecordCount")]
    public int RecordCount { get; set; }
    
    [JsonPropertyName("_nPerpage")]
    public int Perpage { get; set; }
    
    [JsonPropertyName("_bIsComplete")]
    public bool IsComplete { get; set; }
}