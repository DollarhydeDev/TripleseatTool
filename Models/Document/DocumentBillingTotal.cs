using System.Text.Json.Serialization;
using TripleseatTool.Utilities;

namespace TripleseatTool.Models;

public class DocumentBillingTotal
{
    [JsonPropertyName("billing_id")]
    public int? DocumentBillingTotalId { get; init; }

    [JsonPropertyName("description")]
    public string? DocumentBillingTotalDescription { get; init; }

    [JsonPropertyName("value")]
    public string? DocumentBillingTotalValue { get; init; }

    [JsonPropertyName("total_price")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? DocumentBillingTotalPrice { get; init; }
}
