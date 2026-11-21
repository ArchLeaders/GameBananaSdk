using System.Reflection;
using GameBananaSdk;
using GameBananaSdk.Components;
using GameBananaSdk.Models;

var version = typeof(Program).Assembly
    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
    .InformationalVersion.Split('+')[0];
Console.WriteLine($"""
    Owl Merger [{version ?? "v0.0.0-dev"}]
    (c) Arch Leaders. MIT.

    """);
    
using var client = new GameBananaClient();

BananaPage<BananaMod> results;
int page = 1;

Console.WriteLine("Date Added".PadRight(22) + "Name");
do {
    results = await client.Mods.Index(page, pageSize: 50, filters: new BananaFilters()
        .Select("Generic_ContentRatings", "-")
        .Set("Generic_Game", 26242)
        .Set("Generic_Name", "contains,Hy")
        .Build()
    );

    foreach (var result in results.Records) {
        Console.WriteLine($"{result.DateAdded:g}".PadRight(22) + result.Name);
    }
    
    page++;
} while (!results.Metadata.IsComplete);

var filterConfig = await client.Mods.ListFilterConfig();
Console.WriteLine(filterConfig);