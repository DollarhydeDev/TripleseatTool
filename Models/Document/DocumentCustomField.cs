using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class DocumentCustomField
{
    [JsonPropertyName("id")]
    public int? DocumentCustomFieldId { get; init; }

    [JsonPropertyName("name")]
    public string? DocumentCustomFieldName { get; init; }
}