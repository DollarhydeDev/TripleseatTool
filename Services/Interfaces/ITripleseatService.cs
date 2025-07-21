using TripleseatTool.Models;

namespace TripleseatTool.Services.Interfaces;

public interface ITripleseatService
{
    Task<string> GenerateNewAuthTokenAsync(string clientId, string clientSecret);
    Task InvalidateAuthTokenAsync(string authToken);

    Task<List<Location>> GetLocationsAsync(string authToken);
    Task<Location> GetLocationByIdAsync(string authToken, int locationId);

    Task<List<Event>> GetEventsAsync(string authToken);
    Task<Event> GetEventByIdAsync(string authToken, int eventId);
    Task<List<Event>> GetEventsByLocationAsync(string authToken, int locationId);
}