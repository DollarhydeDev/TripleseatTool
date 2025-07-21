using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class LocationRoomDescendant
{
    [JsonPropertyName("id")]
    public int LocationRoomDescendantId { get; init; }

    [JsonPropertyName("name")]
    public string? LocationRoomDescendantName { get; init; }
}
