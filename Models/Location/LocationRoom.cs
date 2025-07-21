using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class LocationRoom
{
    [JsonPropertyName("id")]
    public int? LocationRoomId { get; init; }

    [JsonPropertyName("name")]
    public string? LocationRoomName { get; init; }

    [JsonPropertyName("capacity")]
    public int? LocationRoomCapacity { get; init; }

    [JsonPropertyName("description")]
    public string? LocationRoomDescription { get; init; }

    [JsonPropertyName("is_unassigned")]
    public bool? LocationRoomIsUnassigned { get; init; }

    [JsonPropertyName("descendants")]
    public LocationRoomDescendant[][]? LocationRoomDescendants { get; init; }
}
