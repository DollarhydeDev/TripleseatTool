using TripleseatTool.Models;

namespace TripleseatTool.Services.Interfaces;

public interface ITripleseatService
{
    Task<string> GenerateNewAuthTokenAsync(string clientId, string clientSecret);
    Task InvalidateAuthTokenAsync(string authToken);

    Task<List<Location>> GetLocationsAsync(string authToken);
    Task<List<Location>> GetLocationsAsync(string authToken, LocationsFilter locationsFilter);
    Task<Location> GetLocationByIdAsync(string authToken, int locationId);

    Task<List<Event>> GetEventsAsync(string authToken);
    Task<List<Event>> GetEventsAsync(string authToken, EventsFilter eventsFilter);
    Task<Event> GetEventByIdAsync(string authToken, int eventId);
}