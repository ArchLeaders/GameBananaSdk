global using System.Text.Json.Serialization;
using System.Collections.Immutable;
using System.Text.Json;
using GameBananaSdk.Models;

namespace GameBananaSdk;

[JsonSourceGenerationOptions(JsonSerializerDefaults.Web)]
[JsonSerializable(typeof(BananaCommunitySpotlight))]
[JsonSerializable(typeof(BananaFilterConfig))]
[JsonSerializable(typeof(BananaPage<BananaDiscussion>))]
[JsonSerializable(typeof(BananaPage<BananaGame>))]
[JsonSerializable(typeof(BananaPage<BananaMod>))]
[JsonSerializable(typeof(BananaPage<BananaObject>))]
[JsonSerializable(typeof(ImmutableDictionary<int, string>))]
[JsonSerializable(typeof(ImmutableDictionary<string, ImmutableList<BananaGame>>))]
[JsonSerializable(typeof(ImmutableDictionary<string, JsonElement>))]
[JsonSerializable(typeof(ImmutableList<BananaObject>))]
[JsonSerializable(typeof(ImmutableList<string>))]
internal sealed partial class SdkJsonContext : JsonSerializerContext;
