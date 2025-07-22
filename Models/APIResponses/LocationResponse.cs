using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class LocationResponse
{
    [JsonPropertyName("location")]
    public Location? Location { get; init; }
}
