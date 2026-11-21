namespace GameBananaSdk.Components;

public sealed class BananaFilters
{
    private readonly Dictionary<string, string> _filters = [];
    
    public BananaFilters Select(string key, params IEnumerable<string> values)
        => Set(key, string.Join(',', values));
    
    public BananaFilters Bool(string key, bool value)
        => Set(key, value.ToString());
    
    public BananaFilters Set<T>(string key, T value) where T : notnull
    {
        if (value.ToString() is not { } strValue) {
            throw new InvalidDataException("The provided value has no string value");
        }
        
        _filters[$"_aFilters[{key}]"] = strValue;
        return this;
    }
    
    public Dictionary<string, string> Build() => _filters;
}