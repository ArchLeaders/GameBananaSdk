using GameBananaSdk.Converters;

namespace GameBananaSdk.Models;

public sealed record BananaFile : BananaItem
{
    [JsonPropertyName("_sFile")]
    public string? File { get; set; }

    [JsonPropertyName("_nFilesize")]
    public int? Filesize { get; set; }

    [JsonPropertyName("_tsDateAdded")]
    [JsonConverter(typeof(JsonTimestampToDateTimeOffset))]
    public DateTimeOffset? DateAdded { get; set; }

    [JsonPropertyName("_nDownloadCount")]
    public int? DownloadCount { get; set; }

    [JsonPropertyName("_sDownloadUrl")]
    public string? DownloadUrl { get; set; }

    [JsonPropertyName("_sMd5Checksum")]
    public string? Md5Checksum { get; set; }

    [JsonPropertyName("_sAnalysisState")]
    public string? AnalysisState { get; set; }

    [JsonPropertyName("_sAnalysisResult")]
    public string? AnalysisResult { get; set; }

    [JsonPropertyName("_sAnalysisResultVerbose")]
    public string? AnalysisResultVerbose { get; set; }

    [JsonPropertyName("_sAvState")]
    public string? AvState { get; set; }

    [JsonPropertyName("_sAvResult")]
    public string? AvResult { get; set; }

    [JsonPropertyName("_bIsArchived")]
    public bool? IsArchived { get; set; }

    [JsonPropertyName("_bHasContents")]
    public bool? HasContents { get; set; }
}