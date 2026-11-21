using System.Text.Json;
using GameBananaSdk.Models;

namespace GameBananaSdk.Converters;

public sealed class JsonBananaSubmissionConverter : JsonConverter<BananaObject>
{
    public override BananaObject? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var document = JsonDocument.ParseValue(ref reader);
        return new BananaObject(document.RootElement.Clone());
    }

    public override void Write(Utf8JsonWriter writer, BananaObject value, JsonSerializerOptions options)
    {
        throw new NotSupportedException();
    }
}