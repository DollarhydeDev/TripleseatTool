using System.Text.Json.Serialization;

namespace TripleseatTool.Models;

public class Photo
{
    [JsonPropertyName("original")]
    public string? PhotoOriginal { get; init; }

    [JsonPropertyName("gallery_thumbnail")]
    public string? PhotoGalleryThumbnail { get; init; }

    [JsonPropertyName("gallery")]
    public string? PhotoGallery { get; init; }

    [JsonPropertyName("room")]
    public string? PhotoRoom { get; init; }

    [JsonPropertyName("Standard_listing")]
    public string? PhotoStandardListing { get; init; }

    [JsonPropertyName("size700x400")]
    public string? Photo700by400 { get; init; }
}
