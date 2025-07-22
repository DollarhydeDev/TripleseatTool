using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class Address
{
    [JsonPropertyName("id")]
    public int? AddressId { get; init; }

    [JsonPropertyName("address1")]
    public string? AddressLocation1 { get; init; }

    [JsonPropertyName("address2")]
    public string? AddressLocation2 { get; init; }

    [JsonPropertyName("city")]
    public string? AddressCity { get; init; }

    [JsonPropertyName("state")]
    public string? AddressState { get; init; }

    [JsonPropertyName("country")]
    public string? AddressCountry { get; init; }

    [JsonPropertyName("zip_code")]
    public string? AddressZipCode { get; init; }

    [JsonPropertyName("address_type")]
    public string? AddressType { get; init; }
}
