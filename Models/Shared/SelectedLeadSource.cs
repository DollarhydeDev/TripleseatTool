using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class SelectedLeadSource
{
    [JsonPropertyName("lead_source_id")]
    public int? SelectedLeadSourceId { get; init; }

    [JsonPropertyName("lead_source_other")]
    public string? SelectedLeadSourceOther { get; init; }

    [JsonPropertyName("lead_source_name")]
    public string? SelectedLeadSourceName { get; init; }
}
