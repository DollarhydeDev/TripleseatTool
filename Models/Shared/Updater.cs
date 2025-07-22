using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class Updater
{
    [JsonPropertyName("id")]
    public int? UpdaterId { get; init; }

    [JsonPropertyName("first_name")]
    public string? UpdaterFirstName { get; init; }

    [JsonPropertyName("last_name")]
    public string? UpdaterLastName { get; init; }

    [JsonPropertyName("title")]
    public string? UpdaterTitle { get; init; }

    [JsonPropertyName("email")]
    public string? UpdaterEmailAddressText { get; init; }

    [JsonPropertyName("created_at")]
    public string? UpdaterCreatedAtDate { get; init; }

    [JsonPropertyName("updated_at")]
    public string? UpdaterUpdatedAtDate { get; init; }

    [JsonPropertyName("login_count")]
    public int? UpdaterLoginCount { get; init; }

    [JsonPropertyName("login_at")]
    public string? UpdaterLoggedInAtDate { get; init; }

    [JsonPropertyName("customer_id")]
    public int? UpdaterCustomerId { get; init; }

    [JsonPropertyName("phone_numbers")]
    public PhoneNumber[]? UpdaterPhoneNumbers { get; init; }
}
