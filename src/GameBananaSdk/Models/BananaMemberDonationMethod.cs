namespace GameBananaSdk.Models;

public record BananaMemberDonationMethod
{
    [JsonPropertyName("_sTitle")]
    public string? Title { get; set; }

    [JsonPropertyName("_sValue")]
    public string? Value { get; set; }

    [JsonPropertyName("_sInputType")]
    public string? InputType { get; set; }

    [JsonPropertyName("_sInputPlaceholder")]
    public string? InputPlaceholder { get; set; }

    [JsonPropertyName("_sIconClasses")]
    public string? IconClasses { get; set; }

    [JsonPropertyName("_aValidator")]
    public BananaMemberDonationMethodValidator? Validator { get; set; }

    [JsonPropertyName("_sValueTemplate")]
    public string? ValueTemplate { get; set; }

    [JsonPropertyName("_bIsUrl")]
    public bool? IsUrl { get; set; }

    [JsonPropertyName("_sFormattedValue")]
    public string? FormattedValue { get; set; }
}