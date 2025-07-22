using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class StatusChange
{
    [JsonPropertyName("status")]
    public string? CurrentStatus { get; init; }

    [JsonPropertyName("previous_status")]
    public string? PreviousStatus { get; init; }

    [JsonPropertyName("created_at")]
    public string? CreatedAtDate { get; init; }

    [JsonPropertyName("created_by")]
    public int? CreatedById { get; init; }
}
