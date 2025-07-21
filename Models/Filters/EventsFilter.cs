using System.Text;

namespace TripleseatTool.Models;

public class EventsFilter
{
    public bool? IsActive { get; set; } = null;
    public DateOnly? EventUpdatedStartDate { get; set; } = null;
    public DateOnly? EventUpdatedEndDate { get; set; } = null;
    public int[]? LocationIds { get; set; } = null;

    public string? GenerateURLFromFilters()
    {
        int numberOfParamsAdded = 0;
        var filterUrl = new StringBuilder();

        if (IsActive != null)
        {
            char initialCharacter = numberOfParamsAdded == 0 ? '?' : '&';
            filterUrl.Append($"{initialCharacter}active={IsActive.ToString()?.ToLower()}");
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

        return numberOfParamsAdded == 0 ? null : filterUrl.ToString();
    }
}