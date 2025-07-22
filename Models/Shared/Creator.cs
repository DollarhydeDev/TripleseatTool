using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class Creator
{
    [JsonPropertyName("id")]
    public int? CreatorId { get; init; }

    [JsonPropertyName("first_name")]
    public string? CreatorFirstName { get; init; }

    [JsonPropertyName("last_name")]
    public string? CreatorLastName { get; init; }

    [JsonPropertyName("title")]
    public string? CreatorTitle { get; init; }

    [JsonPropertyName("email")]
    public string? CreatorEmailAddressText { get; init; }

    [JsonPropertyName("created_at")]
    public string? CreatorCreatedAtDate { get; init; }

    [JsonPropertyName("updated_at")]
    public string? CreatorUpdatedAtDate { get; init; }

    [JsonPropertyName("login_count")]
    public int? CreatorLoginCount { get; init; }

    [JsonPropertyName("login_at")]
    public string? CreatorLoggedInAtDate { get; init; }

    [JsonPropertyName("customer_id")]
    public int? CreatorCustomerId { get; init; }

    [JsonPropertyName("phone_numbers")]
    public PhoneNumber[]? CreatorPhoneNumbers { get; init; }
}
