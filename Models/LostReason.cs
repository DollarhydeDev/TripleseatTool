using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class LostReason
{
    [JsonPropertyName("name")]
    public string? LostReasonName { get; init; }

    [JsonPropertyName("id")]
    public int? LostReasonId { get; init; }
}
