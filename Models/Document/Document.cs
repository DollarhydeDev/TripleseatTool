using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class Document
{
    [JsonPropertyName("id")]
    public int? DocumentId { get; init; }

    [JsonPropertyName("title")]
    public string? DocumentTitle { get; init; }

    [JsonPropertyName("template_document_id")]
    public int? DocumentTemplateId { get; init; }

    [JsonPropertyName("deleted_at")]
    public string? DocumentDeletedAtDate { get; init; }

    [JsonPropertyName("views")]
    public DocumentView[]? DocumentViews { get; init; }

    [JsonPropertyName("line_items")]
    public DocumentLineItem[]? DocumentLineItems { get; init; }

    [JsonPropertyName("billing_totals")]
    public DocumentBillingTotal[]? DocumentBillingTotals { get; init; }

    [JsonPropertyName("category_totals")]
    public DocumentCategoryTotal[]? DocumentCategoryTotals { get; init; }

    [JsonPropertyName("financials")]
    public DocumentFinancials? DocumentFinancials { get; init; }

    [JsonPropertyName("payment_set")]
    public DocumentPaymentSet? DocumentPaymentSet { get; init; }
}