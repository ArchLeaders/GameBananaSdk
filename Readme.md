# GameBanana SDK

Semi-dynamic C# SDK for the GameBanana v13 API.

## Usage

### Create a GameBananaClient

```cs
using GameBananaSdk;

// Optionally define a custom base URL (defaults to 'https://gamebanana.com/apiv13')
using var client = new GameBananaClient(baseUrl: ...);
```

### Dynamic Section Queries

Given the undocumented nature of the GameBanana API, much of it remains only dynamically accessible and will require the consuming application to define data models and or dynamically access the desired fields.

For a fully dynamic data model, use the [`BananaObject`](./src/GameBananaSdk/Models/BananaObject.cs) class.


```csharp
using GameBananaSdk.Models;
using GameBananaSdk.QueryBuilders;

// Query a section dynamically
SectionQueryBuiler<BananaObject> section
    = await client.Query("Poll");

// OR, Query a section backed by your data model
SectionQueryBuiler<MyDataModel> section
    = await client.QueryFor<MyDataModel>("Poll");

// Get the filter configuration
var config = await section.ListFilterConfig();

// Get a paginated list of items in the section
BananaPage<BananaObject> page = await section.Index(
    page: 2, pageSize: 50, filters: new BananaFilters()
        // Use filters defined by /ListFilterConfig
        .Build()
);

// Query the section by a known ID
QueryBuilder<BananaObject> itemQuery = section[5432];

// Return the payload (defaults to @gbprofile if none are specified)
BananaObject item = await itemQuery.Get();
BananaObject itemNameOnly = await itemQuery.Get(properties: "_sName");

// Dynamically access the BananaObject (Name is automatically converted to _sName)
Console.WriteLine(item.GetString("Name"))

// Deserialize the BananaObject
var myDataModel = item.Element.Deserialize<MyDataModel>();
Console.WriteLine(myDataMode.Name);

// Example data model
record MyDataModel(
    [property: JsonPropertyName("_sName")] string Name
);
```

### Game Queries

> [!NOTE]
>
> See [Dynamic Section Queries](#dynamic-section-queries) for general usage. This section only shows examples for methods specific to the `Game` section.


```csharp
// Query a game by its ID
var game = client.Games[26242];

// Get the community spotlight for the game
var communitySpotlight = await game.GetCommunitySpotlight();

// Get the submission feed for the game
var communitySpotlight = await game.GetSubmissionFeed();

// Get the top submissions for the game
var communitySpotlight = await game.GetTopSubmissions();
```

### Mod Queries

The `GameBananaClient.Mods` property is synonymous to `GameBananaClient.QueryFor<BananaMod>("Mod")`.

See [Dynamic Section Queries](#dynamic-section-queries) for examples.

### Util Queries

```csharp
using System.Collections.Immutable;
using GameBananaSdk.Models;

// GET /Util/Config/TrashReasons
ImmutableDictionary<int, string> trashReasons
    = await client.Util.Config.TrashReasons.Get();

// GET Util/Homepage/Features
ImmutableList<BananaObject> features
    = await client.Util.Homepage.Features.Get();

// GET Util/Homepage/Submissions
BananaPage<BananaObject> submissions
    = await client.Util.Homepage.Submissions.Get();

// GET Util/Homepage/TopGames
ImmutableDictionary<string, ImmutableList<BananaGame>> topGames
    = await client.Util.Homepage.TopGames.Get();

// GET Util/Game/NameMatch?_sName=Example
BananaPage<BananaGame> games
    = await client.Util.Search.Games.Get(searchTerm: "Example");

// GET Util/Search/Suggestions?_sSearchString=Example&_sModelName=Mod
ImmutableList<string> suggestions
    = await client.Util.Search.Suggestions.Get(searchTerm: "Example", modelName: "Mod");

// GET Util/Search/Results?_sSearchString=Example
BananaPage<BananaObject> searchResults
    = await client.Util.Search.Get(searchTerm: "Example");

// GET Util/Generic/Discussions
BananaPage<BananaDiscussion> discussions
    = await client.Util.Generic.Discussions.Get();

// GET Util/Generic/Tags?_sTag=Example
BananaPage<BananaTag> tags
    = await client.Util.Generic.Tags.Get(searchTerm: "Example");

// GET Util/Search/Results?_sSearchString=Example
BananaPage<BananaObject> featured
    = await client.Util.List.Featured.Get();
```

---

&copy; Arch Leaders. 2026 &mdash; [MIT NON-AI](./License.md)