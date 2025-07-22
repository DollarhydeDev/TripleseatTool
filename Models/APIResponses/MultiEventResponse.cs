using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class MultiEventResponse
{
    [JsonPropertyName("total_pages")]
    public int? TotalPages { get; init; }

    [JsonPropertyName("results")]
    public Event[]? Events { get; init; }
}
