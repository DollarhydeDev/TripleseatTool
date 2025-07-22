using System.Text.Json.Serialization;
using TripleseatTool.Utilities;

namespace TripleseatTool.Models;

public class DocumentFinancials
{
    [JsonPropertyName("amount_due")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? DocumentFinancialsAmountDue { get; init; }

    [JsonPropertyName("grand_total")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? DocumentFinancialsGrandTotal { get; init; }

    [JsonPropertyName("discounts_total")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? DocumentFinancialsDiscountTotal { get; init; }
}
