using System.Text.Json.Serialization;
using TripleseatTool.Utilities;

namespace TripleseatTool.Models;

public class DocumentPayment
{
    [JsonPropertyName("id")]
    public int? DocumentPaymentId { get; init; }

    [JsonPropertyName("amount")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? DocumentPaymentAmount { get; init; }

    [JsonPropertyName("state")]
    public string? DocumentPaymentState { get; init; }

    [JsonPropertyName("custom_title")]
    public string? DocumentPaymentCustomTitle { get; init; }

    [JsonPropertyName("created_at")]
    public string? DocumentPaymentCreatedAtDate { get; init; }

    [JsonPropertyName("due_at")]
    public string? DocumentPaymentDueAtDate { get; init; }

    [JsonPropertyName("paid_at")]
    public string? DocumentPaymentPaidAtDate { get; init; }

    [JsonPropertyName("payable_by_guest")]
    public bool? DocumentPaymentPayableByGuest { get; init; }

    [JsonPropertyName("unpaid_at")]
    public string? DocumentPaymentUnpaidAtDate { get; init; }

    [JsonPropertyName("billing_kind")]
    public string? DocumentPaymentBillingKind { get; init; }

    [JsonPropertyName("payment_method")]
    public string? DocumentPaymentMethod { get; init; }

    [JsonPropertyName("credit_card_type")]
    public string? DocumentPaymentCreditCardType { get; init; }

    [JsonPropertyName("refunded_at")]
    public string? DocumentPaymentRefundedAtDate { get; init; }

    [JsonPropertyName("amount_refunded")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? DocumentPaymentAmountRefunded { get; init; }

    [JsonPropertyName("refund_reason")]
    public string? DocumentPaymentRefundReason { get; init; }

    [JsonPropertyName("paid_by")]
    public string? DocumentPaymentPaidBy { get; init; }

    [JsonPropertyName("custom_field")]
    public DocumentCustomField? DocumentPaymentCustomField { get; init; }
}