using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class CustomField
{
    [JsonPropertyName("id")]
    public int? CustomFieldId { get; init; }

    [JsonPropertyName("custom_field_name")]
    public string? CustomFieldName { get; init; }

    [JsonPropertyName("custom_field_id")]
    public int? CustomFieldId2 { get; init; }

    [JsonPropertyName("custom_field_required")]
    public bool? CustomFieldRequired { get; init; }

    [JsonPropertyName("custom_field_slug")]
    public string? CustomFieldSlug { get; init; }

    [JsonPropertyName("value")]
    public string? CustomFieldValue { get; init; }
}
