using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class DocumentView
{
    [JsonPropertyName("name")]
    public string? DocumentViewName { get; init; }

    [JsonPropertyName("url")]
    public string? DocumentViewURL { get; init; }
}
