using System.Reflection;

var version = typeof(Program).Assembly
    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
    .InformationalVersion.Split('+')[0];
Console.WriteLine($"""
    Owl Merger [{version ?? "v0.0.0-dev"}]
    (c) Arch Leaders. MIT.

    """);