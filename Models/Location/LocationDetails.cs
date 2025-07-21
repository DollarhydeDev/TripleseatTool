using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class LocationDetails
{
    [JsonPropertyName("id")]
    public int? EventLocationId { get; init; }

    [JsonPropertyName("name")]
    public string? EventLocationName { get; init; }

    [JsonPropertyName("customer_id")]
    public int? EventLocationCustomerId { get; init; }

    [JsonPropertyName("site_id")]
    public int? EventLocationSiteId { get; init; }

    [JsonPropertyName("addresses")]
    public Address[]? EventLocationAddresses { get; init; }

    [JsonPropertyName("phone_numbers")]
    public PhoneNumber[]? EventLocationPhoneNumbers { get; init; }
}
