using System.Text.Json;
using System.Text.Json.Serialization;

namespace GameBananaSdk;

[JsonSourceGenerationOptions(JsonSerializerDefaults.Web)]
internal sealed partial class SdkJsonContext : JsonSerializerContext;