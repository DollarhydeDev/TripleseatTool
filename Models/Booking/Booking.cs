using System.Text.Json.Serialization;
using TripleseatTool.Utilities;

namespace TripleseatTool.Models;

public class Booking
{
    [JsonPropertyName("id")]
    public int? BookingId { get; init; }

    [JsonPropertyName("name")]
    public string? BookingName { get; init; }

    [JsonPropertyName("customer_id")]
    public int? BookingCustomerId { get; init; }

    [JsonPropertyName("site_id")]
    public int? BookingSiteId { get; init; }

    [JsonPropertyName("location_id")]
    public int? BookingLocationId { get; init; }

    [JsonPropertyName("event_ids")]
    public int[]? BookingEventIds { get; init; }

    [JsonPropertyName("status")]
    public string? BookingStatus { get; init; }

    [JsonPropertyName("total_event_actual_amount")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? BookingEventTotalActualAmount { get; init; }

    [JsonPropertyName("total_actual_amount")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? BookingActualAmount { get; init; }

    [JsonPropertyName("total_event_grand_total")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? BookingEventGrandTotal { get; init; }

    [JsonPropertyName("total_grand_total")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? BookingGrandTotal { get; init; }

    [JsonPropertyName("post_as")]
    public string? BookingPostAs { get; init; }

    [JsonPropertyName("updated_by")]
    public int? BookingUpdatedById { get; init; }

    [JsonPropertyName("created_by")]
    public int? BookingCreatedById { get; init; }

    [JsonPropertyName("owned_by")]
    public int? BookingOwnedById { get; init; }

    [JsonPropertyName("start_date")]
    public string? BookingStartDate { get; init; }

    [JsonPropertyName("end_date")]
    public string? BookingEndDate { get; init; }

    [JsonPropertyName("definite_date")]
    public string? BookingDefiniteDate { get; init; }

    [JsonPropertyName("tentative_date")]
    public string? BookingTentativeDate { get; init; }

    [JsonPropertyName("lost_date")]
    public string? BookingLostDate { get; init; }

    [JsonPropertyName("created_at")]
    public string? BookingCreatedAtDate { get; init; }

    [JsonPropertyName("updated_at")]
    public string? BookingUpdatedAtDate { get; init; }

    [JsonPropertyName("deleted_at")]
    public string? BookingDeletedAtDate { get; init; }

    [JsonPropertyName("location")]
    public LocationDetails? BookingLocation { get; init; }

    [JsonPropertyName("market_segment")]
    public string? BookingMarketSegment { get; init; }

    [JsonPropertyName("contact")]
    public Contact? BookingContact { get; init; }

    [JsonPropertyName("secondary_contacts")]
    public Contact[]? BookingSecondaryContacts { get; init; }

    [JsonPropertyName("account")]
    public AccountDetails? BookingAccount { get; init; }

    [JsonPropertyName("owner")]
    public Owner? BookingOwner { get; init; }

    [JsonPropertyName("creator")]
    public Creator? BookingCreator { get; init; }

    [JsonPropertyName("updator")]
    public Updater? BookingUpdater { get; init; }

    [JsonPropertyName("status_changes")]
    public StatusChange[]? BookingStatusChanges { get; init; }

    [JsonPropertyName("selected_lead_sources")]
    public SelectedLeadSource[]? BookingSelectedLeadSources { get; init; }

    [JsonPropertyName("booking_forecast")]
    public int? BookingForecast { get; init; }

    [JsonPropertyName("category_forecasts")] // This always shows as null so not sure what to do with it yet
    public int? BookingCategoryForecasts { get; init; }

    [JsonPropertyName("custom_fields")]
    public CustomField[]? BookingCustomFields { get; init; }

    [JsonPropertyName("documents")]
    public Document[]? BookingDocuments { get; init; }
}