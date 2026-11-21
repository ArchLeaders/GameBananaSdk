using System.Collections.Immutable;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using GameBananaSdk.Converters;

namespace GameBananaSdk.Models;

[JsonConverter(typeof(JsonBananaSubmissionConverter))]
public record BananaSubmission : BananaItem
{
    private readonly ImmutableDictionary<string, JsonElement> _fields;

    internal BananaSubmission(ImmutableDictionary<string, JsonElement> fields)
    {
        _fields = fields;
    }
    
    public string? GetString(string propertyName) => _fields[ToBananaPropertyName(propertyName, "s")].GetString();
    
    public int GetNumber(string propertyName) => _fields[ToBananaPropertyName(propertyName, "n")].GetInt32();
    
    public bool GetBool(string propertyName) => _fields[ToBananaPropertyName(propertyName, "b")].GetBoolean();
    
    public T? Get<T>(string propertyName, JsonTypeInfo<T> typeInfo) => _fields[ToBananaPropertyName(propertyName, "a")].Deserialize(typeInfo);
    
    public DateTimeOffset? GetTimestamp(string propertyName)
        => DateTimeOffset.FromUnixTimeSeconds(_fields[ToBananaPropertyName(propertyName, "ts")].GetInt64());

    private static string ToBananaPropertyName(string propertyName, string prefix)
        => propertyName.StartsWith('_') ? propertyName : $"_{prefix}{propertyName}";
}