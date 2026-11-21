namespace GameBananaSdk.Models;

public class BananaMemberBioEntry
{
    [JsonPropertyName("_sTitle")]
    public string? Title { get; set; }

    [JsonPropertyName("_sValue")]
    public string? Value { get; set; }
}