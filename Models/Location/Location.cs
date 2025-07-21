using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class Location
{
    [JsonPropertyName("id")]
    public int? LocationId { get; init; }

    [JsonPropertyName("name")]
    public string? LocationName { get; init; }

    [JsonPropertyName("customer_id")]
    public int? LocationCustomerId { get; init; }

    [JsonPropertyName("site_name")]
    public string? LocationSiteName { get; init; }

    [JsonPropertyName("site_id")]
    public int? LocationSiteId { get; init; }

    [JsonPropertyName("room_ids")]
    public int[]? LocationRoomIds { get; init; }

    [JsonPropertyName("created_at")]
    public string? LocationCreatedAt { get; init; }

    [JsonPropertyName("updated_at")]
    public string? LocationUpdatedAt { get; init; }

    [JsonPropertyName("description")]
    public string? LocationDescription { get; init; }

    [JsonPropertyName("currency_code")]
    public string? LocationCurrencyCode { get; init; }

    [JsonPropertyName("custom_fields")]
    public CustomField[]? LocationCustomFields { get; init; }

    [JsonPropertyName("rooms")]
    public LocationRoom[]? LocationRooms { get; init; }

    [JsonPropertyName("phone_numbers")]
    public PhoneNumber[]? LocationPhoneNumbers { get; init; }

    [JsonPropertyName("addresses")]
    public Address[]? LocationAddresses { get; init; }

    [JsonPropertyName("photos")]
    public Photo[]? LocationPhotos { get; init; }
}
