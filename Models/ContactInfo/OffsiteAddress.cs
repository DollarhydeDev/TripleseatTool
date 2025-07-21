using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class OffsiteAddress
{
    [JsonPropertyName("id")]
    public int? OffsiteAddressId { get; init; }
}
