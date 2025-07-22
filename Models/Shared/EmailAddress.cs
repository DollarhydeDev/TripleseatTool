using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class EmailAddress
{
    [JsonPropertyName("id")]
    public int? EmailId { get; init; }

    [JsonPropertyName("address")]
    public string? EmailAddressText { get; init; }
}