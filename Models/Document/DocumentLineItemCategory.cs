using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class DocumentLineItemCategory
{
    [JsonPropertyName("id")]
    public int? DocumentLineItemCategoryId { get; init; }

    [JsonPropertyName("name")]
    public string? DocumentLineItemCategoryName { get; init; }

    [JsonPropertyName("internal_name")]
    public string? DocumentLineItemCategoryInternalName { get; init; }
}