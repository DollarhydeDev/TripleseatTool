using System.Text.Json.Serialization;
using TripleseatTool.Utilities;

namespace TripleseatTool.Models;

public class Event
{
    [JsonPropertyName("id")]
    public int? EventId { get; init; }

    [JsonPropertyName("name")]
    public string? EventName { get; init; }

    [JsonPropertyName("event_date")]
    public string? EventDate { get; init; }

    [JsonPropertyName("event_date_iso8601")]
    public string? EventDateISO { get; init; }

    [JsonPropertyName("status")]
    public string? EventStatus { get; init; }

    [JsonPropertyName("event_start")]
    public string? EventStart { get; init; }

    [JsonPropertyName("event_end")]
    public string? EventEnd { get; init; }

    [JsonPropertyName("event_start_utc")]
    public string? EventStartUTC { get; init; }

    [JsonPropertyName("event_end_utc")]
    public string? EventEndUTC { get; init; }

    [JsonPropertyName("event_start_iso8601")]
    public string? EventStartISO { get; init; }

    [JsonPropertyName("event_end_iso8601")]
    public string? EventEndISO { get; init; }

    [JsonPropertyName("event_start_time")]
    public string? EventStartTime { get; init; }

    [JsonPropertyName("event_end_time")]
    public string? EventEndTime { get; init; }

    [JsonPropertyName("start_date")]
    public string? EventStartDate { get; init; }

    [JsonPropertyName("end_date")]
    public string? EventEndDate { get; init; }

    [JsonPropertyName("setup_time")]
    public int? EventSetupTime { get; init; }

    [JsonPropertyName("teardown_time")]
    public int? EventTeardownTime { get; init; }

    [JsonPropertyName("event_start_time_with_setup_time")]
    public string? EventStartTimeWithSetupTime { get; init; }

    [JsonPropertyName("event_end_time_with_teardown_time")]
    public string? EventEndTimeWithTeardownTime { get; init; }

    [JsonPropertyName("event_start_with_setup_iso8601")]
    public string? EventStartTimeWithSetupTimeISO { get; init; }

    [JsonPropertyName("event_end_with_teardown_iso8601")]
    public string? EventEndTimeWithTeardownTimeISO { get; init; }

    [JsonPropertyName("event_timezone")]
    public string? EventTimezone { get; init; }

    [JsonPropertyName("event_style")]
    public string? EventStyle { get; init; }

    [JsonPropertyName("guaranteed_guest_count")]
    public int? EventGuaranteedGuestCount { get; init; }

    [JsonPropertyName("guest_count")]
    public int? EventGuestCount { get; init; }

    [JsonPropertyName("food_and_beverage_min")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? EVentFoodAndBeverageMinimum { get; init; }

    [JsonPropertyName("price_per_person")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? EventPricePerPerson { get; init; }

    [JsonPropertyName("deposit_amount")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? EventDepositAmount { get; init; }

    [JsonPropertyName("rental_fee")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? EventRentalFee { get; init; }

    [JsonPropertyName("actual_amount")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? EventActualAmount { get; init; }

    [JsonPropertyName("grand_total")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? EventGrandTotal { get; init; }

    [JsonPropertyName("amount_due")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? EventAmountDue { get; init; }

    [JsonPropertyName("description")]
    public string? EventDescription { get; init; }

    [JsonPropertyName("contact_id")]
    public int? EventContactId { get; init; }

    [JsonPropertyName("account_id")]
    public int? EventAccountId { get; init; }

    [JsonPropertyName("owned_by")]
    public int? EventOwnedById { get; init; }

    [JsonPropertyName("created_at")]
    public string? EventCreatedAt { get; init; }

    [JsonPropertyName("updated_at")]
    public string? EventUpdatedAt { get; init; }

    [JsonPropertyName("deleted_at")]
    public string? EventDeletedAt { get; init; }

    [JsonPropertyName("booking_id")]
    public int? EventBookingId { get; init; }

    [JsonPropertyName("updated_by")]
    public int? EventUpdatedById { get; init; }

    [JsonPropertyName("created_by")]
    public int? EventCreatedById { get; init; }

    [JsonPropertyName("customer_id")]
    public int? EventCustomerId { get; init; }

    [JsonPropertyName("site_id")]
    public int? EventSiteId { get; init; }

    [JsonPropertyName("location_id")]
    public int? EventLocationId { get; init; }

    [JsonPropertyName("room_ids")]
    public int[]? EventRoomIds { get; init; }

    [JsonPropertyName("managing_user_ids")]
    public int[]? EventManagingUserIds { get; init; }

    [JsonPropertyName("unassigned")]
    public bool? EventIsUnassigned { get; init; }

    [JsonPropertyName("event_type_id")]
    public int? EventTypeId { get; init; }

    [JsonPropertyName("post_as")]
    public string? EventPostAs { get; init; }

    [JsonPropertyName("delivery_instructions")]
    public string? EventDeliveryInstructions { get; init; }

    [JsonPropertyName("selected_gratuity")]
    public string? EventSelectedGratuity { get; init; }

    [JsonPropertyName("offsite_address")]
    public OffsiteAddress? EventOffsiteAddress { get; init; }

    [JsonPropertyName("document_ids")]
    public string? EventDocumentId { get; init; }

    [JsonPropertyName("start_time")]
    public string? EventStartDateTime { get; init; }

    [JsonPropertyName("end_time")]
    public string? EventEndDateTime { get; init; }

    [JsonPropertyName("event_type")]
    public string? EventType { get; init; }

    [JsonPropertyName("lost_reason")]
    public LostReason? EventLostReason { get; init; }

    [JsonPropertyName("rooms")]
    public EventRoom[]? EventRooms { get; init; }

    [JsonPropertyName("location")]
    public LocationDetails? EventLocation { get; init; }

    [JsonPropertyName("booking")]
    public Booking? EventBooking { get; init; }

    [JsonPropertyName("documents")]
    public Document[]? EventDocuments { get; init; }

    [JsonPropertyName("custom_fields")]
    public CustomField[]? EventCustomFields { get; init; }

    [JsonPropertyName("category_totals")]
    public CategoryTotal[]? EventCategoryTotals { get; init; }

    [JsonPropertyName("billing_totals")]
    public BillingTotal[]? EventBillingTotals { get; init; }

    [JsonPropertyName("owner")]
    public Owner? EventOwner { get; init; }

    [JsonPropertyName("creator")]
    public Creator? EventCreator { get; init; }

    [JsonPropertyName("updator")]
    public Updater? EventUpdater { get; init; }

    [JsonPropertyName("managers")] // This was null so need to revisit type
    public int[]? EventManagers { get; init; }

    [JsonPropertyName("selected_lead_sources")]
    public SelectedLeadSource[]? EventSelectedLeadSources { get; init; }

    [JsonPropertyName("contact")]
    public Contact? EventContact { get; init; }

    [JsonPropertyName("secondary_contacts")]
    public Contact[]? EventSecondaryContacts { get; init; }

    [JsonPropertyName("account")]
    public AccountDetails? EventAccount { get; init; }

    [JsonPropertyName("status_changes")]
    public StatusChange[]? EventStatusChanges { get; init; }

    [JsonPropertyName("attachments")]
    public Attachment[]? EventAttachments { get; init; }
}