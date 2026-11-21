namespace GameBananaSdk.Models;

public record BananaMemberDonationMethodValidator
{
    [JsonPropertyName("_regexValidPattern")]
    public string? ValidPattern { get; set; }

    [JsonPropertyName("_sWarningMessage")]
    public string? WarningMessage { get; set; }
}