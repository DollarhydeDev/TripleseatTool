using System.Text.Json.Serialization;
using TripleseatTool.Utilities;

namespace TripleseatTool.Models;

public class DocumentLineItem
{
    [JsonPropertyName("id")]
    public int? LineItemId { get; init; }

    [JsonPropertyName("quantity")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? LineItemQuantity { get; init; }

    [JsonPropertyName("price")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? LineItemPrice { get; init; }

    [JsonPropertyName("total_price")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? LineItemTotalPrice { get; init; }

    [JsonPropertyName("discount")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? LineItemDiscount { get; init; }

    [JsonPropertyName("position")]
    public int? LineItemPosition { get; init; }

    [JsonPropertyName("billing_ids")]
    public int[]? LineItemBillingIds { get; init; }

    [JsonPropertyName("grand_total")]
    [JsonConverter(typeof(JsonStringConverter))]
    public string? LineItemGrandTotal { get; init; }

    [JsonPropertyName("display_name")]
    public string? LineItemDisplayName { get; init; }

    [JsonPropertyName("description")]
    public string? LineItemDescription { get; init; }

    [JsonPropertyName("long_description")]
    public string? LineItemLongDescription { get; init; }

    [JsonPropertyName("category")]
    public DocumentLineItemCategory? LineItemCategory { get; init; }

    [JsonPropertyName("section")]
    public string? LineItemSection { get; init; }

    [JsonPropertyName("section_position")]
    public int? LineItemSectionPosition { get; init; }

    [JsonPropertyName("menu_item_id")]
    public int? LineItemMenuId { get; init; }
}