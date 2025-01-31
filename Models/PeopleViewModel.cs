using System.Text.Json.Serialization;

namespace SwapiMVC2.Models;

public class PeopleViewModel
{
    [JsonPropertyName("name")]
    public string? Name { get; set;}

    [JsonPropertyName("height")]
    public string? Height { get; set;}

    [JsonPropertyName("mass")]
    public string? Mass { get; set;}

    [JsonPropertyName("birth_year")]
    public string? Birthyear { get; set;}
    
    [JsonPropertyName("url")]
    public string? Url { get; set;}

    public string? Id
    {
        get
        {
            return Url?
             .Split("/", StringSplitOptions.RemoveEmptyEntries)
             .LastOrDefault();
        }
    }
}