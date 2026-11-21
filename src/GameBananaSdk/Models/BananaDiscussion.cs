namespace GameBananaSdk.Models;

public record BananaDiscussion : BananaItem
{
    [JsonPropertyName("_aSubmission")]
    public required BananaObject Submission { get; set; }
    
    [JsonPropertyName("_aPost")]
    public required BananaObject Post { get; set; }
}