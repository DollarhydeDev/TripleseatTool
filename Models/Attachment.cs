using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class Attachment
{
    [JsonPropertyName("content_type")]
    public string? AttachmentContentType { get; init; }

    [JsonPropertyName("filename")]
    public string? AttachmentFileName { get; init; }

    [JsonPropertyName("url")]
    public string? AttachmentURL { get; init; }
}
