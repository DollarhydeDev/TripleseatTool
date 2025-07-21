using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class Owner
{
    [JsonPropertyName("id")]
    public int? OwnerId { get; init; }

    [JsonPropertyName("first_name")]
    public string? OwnerFirstName { get; init; }

    [JsonPropertyName("last_name")]
    public string? OwnerLastName { get; init; }

    [JsonPropertyName("title")]
    public string? OwnerTitle { get; init; }

    [JsonPropertyName("email")]
    public string? OwnerEmailAddressText { get; init; }

    [JsonPropertyName("created_at")]
    public string? OwnerCreatedAtDate { get; init; }

    [JsonPropertyName("updated_at")]
    public string? OwnerUpdatedAtDate { get; init; }

    [JsonPropertyName("login_count")]
    public int? OwnerLoginCount { get; init; }

    [JsonPropertyName("login_at")]
    public string? OwnerLoggedInAtDate { get; init; }

    [JsonPropertyName("customer_id")]
    public int? OwnerCustomerId { get; init; }

    [JsonPropertyName("phone_numbers")]
    public PhoneNumber[]? OwnerPhoneNumbers { get; init; }
}
