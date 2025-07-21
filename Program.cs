using TripleseatTool.Models;
using TripleseatTool.Services.Implementations;

namespace TripleseatTool
{
    internal class Program
    {
        static async Task Main()
        {
            var tripleseatService = new TripleseatService();

            // Auth Example
            var clientId = "YOUR_CLIENT_ID";
            var clientSecret = "YOUR_CLIENT_SECRET";
            var authToken = await tripleseatService.GenerateNewAuthTokenAsync(clientId, clientSecret);

            // Location Examples
            int exampleLocationId = 0;
            var locations = await tripleseatService.GetLocationsAsync(authToken);
            var specificLocation = await tripleseatService.GetLocationByIdAsync(authToken, exampleLocationId);

            // Event Examples
            int exampleEventId = 0;
            var events = await tripleseatService.GetEventsAsync(authToken);
            var specificEvent = await tripleseatService.GetEventByIdAsync(authToken, exampleEventId);
            var eventFilter = new EventsFilter()
            {
                IsActive = true,
                EventUpdatedStartDate = new DateOnly(2025, 7, 1),
                EventUpdatedEndDate = new DateOnly(2025, 7, 1),
                LocationIds = new int[] { exampleLocationId },
            };
            var filteredEvents = await tripleseatService.GetEventsAsync(authToken, eventFilter);
        }
    }
}