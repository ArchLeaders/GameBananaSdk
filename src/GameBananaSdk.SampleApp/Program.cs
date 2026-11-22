using System.Diagnostics;
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

var file = await client.Files[1898743].Get("_sName");
Console.WriteLine(file);

IProgress<double> progress = new Progress<double>(progress => {
    Console.WriteLine($"\rDownloading: {progress:F1}%    ");
});

await using var stream = await client.Files[1898743].Download();
await using var fs = File.Create(file.File ?? "unknown.zip");

var buffer = new byte[8192];
long totalBytesRead = 0;
int bytesRead;

while ((bytesRead = await stream.ReadAsync(buffer)) > 0)
{
    await fs.WriteAsync(buffer.AsMemory(0, bytesRead));
    totalBytesRead += bytesRead;

    if (file.Filesize is { } fileSize) {
        double percentage = (double)totalBytesRead / fileSize * 100;
        progress.Report(percentage);
    }
}