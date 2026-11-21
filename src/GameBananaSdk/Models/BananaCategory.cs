namespace GameBananaSdk.Models;

public class BananaCategory
{
    [JsonPropertyName("_idRow")]
    public int IdRow { get; set; }

    [JsonPropertyName("_sName")]
    public string? Name { get; set; }

    [JsonPropertyName("_sModelName")]
    public string? ModelName { get; set; }

    [JsonPropertyName("_sProfileUrl")]
    public string? ProfileUrl { get; set; }

    [JsonPropertyName("_sIconUrl")]
    public string? IconUrl { get; set; }
}