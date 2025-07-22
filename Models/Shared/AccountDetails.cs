using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class AccountDetails
{
    [JsonPropertyName("id")]
    public int? AccountId { get; init; }

    [JsonPropertyName("name")]
    public string? AccountName { get; init; }
}
