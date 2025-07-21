using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class Lead
{
    [JsonPropertyName("id")]
    public int? LeadId { get; init; }

    [JsonPropertyName("first_name")]
    public string? LeadFirstName { get; init; }

    [JsonPropertyName("last_name")]
    public string? LeadLastName { get; init; }

    [JsonPropertyName("company")]
    public string? LeadCompany { get; init; }

    [JsonPropertyName("phone_number")]
    public string? LeadPhoneNumberText { get; init; }

    [JsonPropertyName("phone_number_extension")]
    public string? LeadPhoneNumberExtensionText { get; init; }

    [JsonPropertyName("email_address")]
    public string? LeadEmailAddressText { get; init; }

    [JsonPropertyName("additional_information")]
    public string? LeadAdditionalInformation { get; init; }

    [JsonPropertyName("lead_form_id")]
    public int? LeadFormId { get; init; }

    [JsonPropertyName("owned_by")]
    public int? LeadOwnedBy { get; init; }

    [JsonPropertyName("contact_preference")]
    public string? LeadContactPreference { get; init; }

    [JsonPropertyName("referral_source_id")]
    public int? LeadReferralSourceId { get; init; }

    [JsonPropertyName("referral_source_other")]
    public string? LeadReferralSourceOther { get; init; }

    [JsonPropertyName("event_style")]
    public string? LeadEventStyle { get; init; }

    [JsonPropertyName("converted_at")]
    public string? LeadConvertedAt { get; init; }

    [JsonPropertyName("created_at")]
    public string? LeadCreatedAt { get; init; }

    [JsonPropertyName("updated_at")]
    public string? LeadUpdatedAt { get; init; }

    [JsonPropertyName("deleted_at")]
    public string? LeadDeletedAt { get; init; }
}
