using System.Collections.Immutable;
using System.Text.Json;
using GameBananaSdk.Models;

namespace GameBananaSdk.Converters;

public sealed class JsonBananaSubmissionConverter : JsonConverter<BananaSubmission>
{
    public override BananaSubmission? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return new BananaSubmission(
            JsonSerializer.Deserialize<ImmutableDictionary<string, JsonElement>>(ref reader,
            SdkJsonContext.Default.ImmutableDictionaryStringJsonElement) ?? []);
    }

    public override void Write(Utf8JsonWriter writer, BananaSubmission value, JsonSerializerOptions options)
    {
        throw new NotSupportedException();
    }
}