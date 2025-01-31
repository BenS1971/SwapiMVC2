using System.Text.Json.Serialization;

namespace SwapiMVC2.Models;

public class ResultsViewModel<TResult>
{
    [JsonPropertyName("count")]
    public int Count { get; set;}

    [JsonPropertyName ("next")]
    public string? Next { get; set;}

    [JsonPropertyName ("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<TResult> Results { get; set;} = null!;

    public string? NextPageNum => Next?.Split("?page=").LastOrDefault();
    public string? PreviousPageNum => Previous?.Split("?page=").LastOrDefault();
}
