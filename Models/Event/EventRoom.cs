using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class EventRoom
{
    [JsonPropertyName("id")]
    public int? EventRoomId { get; init; }

    [JsonPropertyName("name")]
    public string? EventRoomName { get; init; }

    [JsonPropertyName("capacity")]
    public int? EventRoomCapacity { get; init; }

    [JsonPropertyName("description")]
    public string? EventRoomDescription { get; init; }

    [JsonPropertyName("site_id")]
    public int? EventRoomSiteId { get; init; }

    [JsonPropertyName("location_id")]
    public int? EventRoomLocationId { get; init; }

    [JsonPropertyName("is_unassigned")]
    public bool? EventRoomIsUnassigned { get; init; }
}
