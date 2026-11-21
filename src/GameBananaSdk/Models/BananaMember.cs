using System.Collections.Immutable;
using GameBananaSdk.Converters;

namespace GameBananaSdk.Models;

public record BananaMember : BananaItem
{
    [JsonPropertyName("_sName")]
    public string? Name { get; set; }

    [JsonPropertyName("_sUserTitle")]
    public string? UserTitle { get; set; }

    [JsonPropertyName("_sHonoraryTitle")]
    public string? HonoraryTitle { get; set; }

    [JsonPropertyName("_tsJoinDate")]
    [JsonConverter(typeof(JsonTimestampToDateTimeOffset))]
    public DateTimeOffset? JoinDate { get; set; }

    [JsonPropertyName("_sAvatarUrl")]
    public string? AvatarUrl { get; set; }

    [JsonPropertyName("_sSigUrl")]
    public string? SigUrl { get; set; }

    [JsonPropertyName("_sProfileUrl")]
    public string? ProfileUrl { get; set; }

    [JsonPropertyName("_sPointsUrl")]
    public string? PointsUrl { get; set; }

    [JsonPropertyName("_sMedalsUrl")]
    public string? MedalsUrl { get; set; }

    [JsonPropertyName("_bIsOnline")]
    public bool? IsOnline { get; set; }

    [JsonPropertyName("_sLocation")]
    public string? Location { get; set; }

    [JsonPropertyName("_sOnlineTitle")]
    public string? OnlineTitle { get; set; }

    [JsonPropertyName("_sOfflineTitle")]
    public string? OfflineTitle { get; set; }

    [JsonPropertyName("_nPoints")]
    public int? Points { get; set; }

    [JsonPropertyName("_nPointsRank")]
    public int? PointsRank { get; set; }

    [JsonPropertyName("_bHasRipe")]
    public bool? HasRipe { get; set; }

    [JsonPropertyName("_nBuddyCount")]
    public int? BuddyCount { get; set; }

    [JsonPropertyName("_nSubscriberCount")]
    public int? SubscriberCount { get; set; }

    [JsonPropertyName("_aDonationMethods")]
    public ImmutableList<BananaMemberDonationMethod>? DonationMethods { get; set; }

    [JsonPropertyName("_aBio")]
    public ImmutableList<BananaMemberBioEntry>? Bio { get; set; }
}