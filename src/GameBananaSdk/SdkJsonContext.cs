global using System.Text.Json.Serialization;
using System.Collections.Immutable;
using System.Text.Json;
using GameBananaSdk.Models;

namespace GameBananaSdk;

[JsonSourceGenerationOptions(JsonSerializerDefaults.Web)]
[JsonSerializable(typeof(BananaFilterConfig))]
[JsonSerializable(typeof(BananaPage<BananaMod>))]
[JsonSerializable(typeof(BananaPage<BananaSubmission>))]
[JsonSerializable(typeof(ImmutableDictionary<string, JsonElement>))]
internal sealed partial class SdkJsonContext : JsonSerializerContext;