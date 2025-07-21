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
}
