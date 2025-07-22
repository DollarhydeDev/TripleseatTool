using System.Text;

namespace TripleseatTool.Models;

public class EventsFilter
{
    public int? PageNumber { get; set; } = null;
    public bool? IsActive { get; set; } = null;
    public bool? ShowFinancial { get; set; } = null;
    public DateOnly? EventUpdatedStartDate { get; set; } = null;
    public DateOnly? EventUpdatedEndDate { get; set; } = null;
    public EventStatus? EventStatus { get; set; } = null;
    public EventOrderBy? EventOrderBy { get; set; } = null;
    public EventSortDirection? EventSortDirection { get; set; } = null;
    public int[]? LocationIds { get; set; } = null;
    public int[]? RoomIds { get; set; } = null;

    public string? GenerateURLFromFilters()
    {
        int numberOfParamsAdded = 0;
        var filterUrl = new StringBuilder();

        if (PageNumber != null)
        {
            char initialCharacter = numberOfParamsAdded == 0 ? '?' : '&';
            filterUrl.Append($"{initialCharacter}page={PageNumber}");
            numberOfParamsAdded += 1;
        }

        if (IsActive != null)
        {
            char initialCharacter = numberOfParamsAdded == 0 ? '?' : '&';
            filterUrl.Append($"{initialCharacter}active={IsActive.ToString()?.ToLower()}");
            numberOfParamsAdded += 1;
        }
        if (ShowFinancial != null)
        {
            char initialCharacter = numberOfParamsAdded == 0 ? '?' : '&';
            filterUrl.Append($"{initialCharacter}show_financial={ShowFinancial.ToString()?.ToLower()}");
            numberOfParamsAdded += 1;
        }

        if (EventUpdatedStartDate != null)
        {
            char initialCharacter = numberOfParamsAdded == 0 ? '?' : '&';
            filterUrl.Append($"{initialCharacter}event_updated_start_date={EventUpdatedStartDate:MM/dd/yyyy}");
            numberOfParamsAdded += 1;
        }
        if (EventUpdatedEndDate != null)
        {
            char initialCharacter = numberOfParamsAdded == 0 ? '?' : '&';
            filterUrl.Append($"{initialCharacter}event_updated_end_date={EventUpdatedEndDate:MM/dd/yyyy}");
            numberOfParamsAdded += 1;
        }

        if (LocationIds != null && LocationIds.Length > 0)
        {
            char initialCharacter = numberOfParamsAdded == 0 ? '?' : '&';
            filterUrl.Append($"{initialCharacter}location_ids=");

            for (int i = 0; i < LocationIds.Length; i++)
            {
                filterUrl.Append($"{LocationIds[i]}");
                if (i < LocationIds.Length - 1)
                {
                    filterUrl.Append(",");
                }
            }

            numberOfParamsAdded += 1;
        }
        if (RoomIds != null && RoomIds.Length > 0)
        {
            char initialCharacter = numberOfParamsAdded == 0 ? '?' : '&';
            filterUrl.Append($"{initialCharacter}room_ids=");

            for (int i = 0; i < RoomIds.Length; i++)
            {
                filterUrl.Append($"{RoomIds[i]}");
                if (i < RoomIds.Length - 1)
                {
                    filterUrl.Append(",");
                }
            }

            numberOfParamsAdded += 1;
        }

        if (EventStatus != null)
        {
            char initialCharacter = numberOfParamsAdded == 0 ? '?' : '&';
            filterUrl.Append($"{initialCharacter}status={EventStatus.ToString()?.ToLower()}");
            numberOfParamsAdded += 1;
        }
        if (EventOrderBy != null)
        {
            char initialCharacter = numberOfParamsAdded == 0 ? '?' : '&';

            var orderText = EventOrderBy switch
            {
                Models.EventOrderBy.CreatedAt => "created_at",
                Models.EventOrderBy.UpdatedAt => "updated_at",
                Models.EventOrderBy.EventStart => "event_start",
                Models.EventOrderBy.EventName => "name",
                _ => throw new Exception("Unrecognized event order")
            };

            filterUrl.Append($"{initialCharacter}order={orderText}");
            numberOfParamsAdded += 1;

            if (EventSortDirection != null)
            {
                initialCharacter = '&';
                filterUrl.Append($"{initialCharacter}sort_direction={EventSortDirection.ToString()?.ToLower()}");
                numberOfParamsAdded += 1;
            }
        }

        return numberOfParamsAdded == 0 ? null : filterUrl.ToString();
    }
}