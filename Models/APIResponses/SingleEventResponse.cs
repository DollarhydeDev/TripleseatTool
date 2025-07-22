using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class SingleEventResponse
{
    [JsonPropertyName("event")]
    public Event? Event { get; init; }
}
