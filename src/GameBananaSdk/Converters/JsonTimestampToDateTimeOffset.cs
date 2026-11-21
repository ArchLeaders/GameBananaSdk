using System.Text.Json;

namespace GameBananaSdk.Converters;

public class JsonTimestampToDateTimeOffset : JsonConverter<DateTimeOffset?>
{
    public override DateTimeOffset? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TryGetInt64(out long ts)) {
            return DateTimeOffset.FromUnixTimeSeconds(ts);
        }
        
        return null;
    }

    public override void Write(Utf8JsonWriter writer, DateTimeOffset? value, JsonSerializerOptions options)
    {
        if (value is { } ts) {
            writer.WriteNumberValue(ts.ToUnixTimeSeconds());
            return;
        }
        
        writer.WriteNullValue();
    }
}