using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class PhoneNumber
{
    [JsonPropertyName("id")]
    public int? PhoneNumberId { get; init; }

    [JsonPropertyName("number")]
    public string? PhoneNumberText { get; init; }

    [JsonPropertyName("phone_number_type")]
    public string? PhoneNumberType { get; init; }

    [JsonPropertyName("extension")]
    public string? PhoneNumberExtension { get; init; }
}
