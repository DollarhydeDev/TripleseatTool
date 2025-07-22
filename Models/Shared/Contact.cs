using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class Contact
{
    [JsonPropertyName("id")]
    public int? ContactId { get; init; }

    [JsonPropertyName("first_name")]
    public string? ContactFirstName { get; init; }

    [JsonPropertyName("last_name")]
    public string? ContactLastName { get; init; }

    [JsonPropertyName("account_id")]
    public int? ContactAccountId { get; init; }

    [JsonPropertyName("email_addresses")]
    public EmailAddress[]? ContactEmailAddresses { get; init; }

    [JsonPropertyName("phone_numbers")]
    public PhoneNumber[]? ContactPhoneNumbers { get; init; }
}