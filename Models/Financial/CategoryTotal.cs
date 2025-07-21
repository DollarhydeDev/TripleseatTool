using System.Text.Json.Serialization;
using TripleseatTool.Utilities;

namespace TripleseatTool.Models;

public class CategoryTotal
{
    [JsonPropertyName("name")]
    public string? CategoryTotalName { get; init; }

    [JsonPropertyName("total")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? CategoryTotalAmount { get; init; }
}
