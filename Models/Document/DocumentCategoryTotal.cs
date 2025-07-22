using System.Text.Json.Serialization;
using TripleseatTool.Utilities;

namespace TripleseatTool.Models;

public class DocumentCategoryTotal
{
    [JsonPropertyName("name")]
    public string? DocumentCategoryTotalName { get; init; }

    [JsonPropertyName("value")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? DocumentCategoryTotalValue { get; init; }
}
