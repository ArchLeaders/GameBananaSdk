using System.Collections.Immutable;
using System.Text.Json;
using GameBananaSdk.Converters;

namespace GameBananaSdk.Models;

public sealed record BananaMod : BananaItem
{
    [JsonPropertyName("_nStatus")]
    public string? Status { get; set; }

    [JsonPropertyName("_bIsPrivate")]
    public bool? IsPrivate { get; set; }

    [JsonPropertyName("_tsDateModified")]
    [JsonConverter(typeof(JsonTimestampToDateTimeOffset))]
    public DateTimeOffset? DateModified { get; set; }

    [JsonPropertyName("_tsDateUpdated")]
    [JsonConverter(typeof(JsonTimestampToDateTimeOffset))]
    public DateTimeOffset? DateUpdated { get; set; }

    [JsonPropertyName("_tsDateAdded")]
    [JsonConverter(typeof(JsonTimestampToDateTimeOffset))]
    public DateTimeOffset? DateAdded { get; set; }

    [JsonPropertyName("_bIsWithheld")]
    public bool? IsWithheld { get; set; }

    [JsonPropertyName("_nPostCount")]
    public int? PostCount { get; set; }

    [JsonPropertyName("_bCreatedBySubmitter")]
    public bool? CreatedBySubmitter { get; set; }

    [JsonPropertyName("_bIsPorted")]
    public bool? IsPorted { get; set; }

    [JsonPropertyName("_nThanksCount")]
    public int? ThanksCount { get; set; }

    [JsonPropertyName("_nSubscriberCount")]
    public int? SubscriberCount { get; set; }

    [JsonPropertyName("_sName")]
    public string? Name { get; set; }

    [JsonPropertyName("_bIsNsfw")]
    public bool? IsNsfw { get; set; }

    [JsonPropertyName("_sProfileUrl")]
    public string? ProfileUrl { get; set; }

    [JsonPropertyName("_nDownloadCount")]
    public int? DownloadCount { get; set; }

    [JsonPropertyName("_sDownloadUrl")]
    public string? DownloadUrl { get; set; }

    [JsonPropertyName("_aAdditionalInfo")]
    public BananaModAdditionalInfo? AdditionalInfo { get; set; }

    [JsonPropertyName("_nViewCount")]
    public int? ViewCount { get; set; }

    [JsonPropertyName("_nLikeCount")]
    public int? LikeCount { get; set; }

    [JsonPropertyName("_bIsTrashed")]
    public bool? IsTrashed { get; set; }

    [JsonPropertyName("_bIsObsolete")]
    public bool? IsObsolete { get; set; }

    [JsonPropertyName("_sLicense")]
    public string? License { get; set; }

    [JsonPropertyName("_aLicenseChecklist")]
    public ImmutableDictionary<string, ImmutableList<string>>? LicenseChecklist { get; set; }

    [JsonPropertyName("_sDevNotes")]
    public string? DevNotes { get; set; }

    [JsonPropertyName("_aRequirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("_aEmbeddedMedia")]
    public string? EmbeddedMedia { get; set; }

    [JsonPropertyName("_aCredits")]
    public ImmutableDictionary<string, ImmutableList<ImmutableList<JsonElement>>>? Credits { get; set; }

    [JsonPropertyName("_bAcceptsDonations")]
    public bool? AcceptsDonations { get; set; }

    [JsonPropertyName("_aAlternateFileSources")]
    public ImmutableList<BananaModAlternateSource>? AlternateFileSources { get; set; }

    [JsonPropertyName("_sModeratorNotice")]
    public string? ModeratorNotice { get; set; }

    [JsonPropertyName("_aCategory")]
    public BananaCategory? Category { get; set; }

    [JsonPropertyName("_aSuperCategory")]
    public BananaCategory? SuperCategory { get; set; }

    [JsonPropertyName("_aGame")]
    public BananaGame? Game { get; set; }

    [JsonPropertyName("_sObsolescenceNotice")]
    public string? ObsolescenceNotice { get; set; }

    [JsonPropertyName("_aTrashInfo")]
    public BananaModTrashInfo? TrashInfo { get; set; }

    [JsonPropertyName("_aSubmitter")]
    public BananaMember? Submitter { get; set; }

    [JsonPropertyName("_aFiles")]
    public ImmutableList<BananaFile>? Files { get; set; }
}