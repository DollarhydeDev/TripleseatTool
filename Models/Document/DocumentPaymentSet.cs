using System.Text.Json.Serialization;
using TripleseatTool.Utilities;

namespace TripleseatTool.Models;

public class DocumentPaymentSet
{
    [JsonPropertyName("amount_due")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? DocumentPaymentSetAmountDue { get; init; }

    [JsonPropertyName("running_balance")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? DocumentPaymentSetRunningBalance { get; init; }

    [JsonPropertyName("remaining_payment_amount")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? DocumentPaymentSetRemainingBalance { get; init; }

    [JsonPropertyName("document_name")]
    public string? DocumentPaymentSetName { get; init; }

    [JsonPropertyName("payments")]
    public DocumentPayment[]? DocumentPaymentSetPayments { get; init; }
}