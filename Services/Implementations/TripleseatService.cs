using System.Text;
using System.Text.Json;
using TripleseatTool.Models;
using TripleseatTool.Services.Interfaces;

namespace TripleseatTool.Services.Implementations;

public class TripleseatService : ITripleseatService
{
    private async Task<HttpResponseMessage> GetAsync(HttpClient httpClient, string requestURL, bool printOutput = true)
    {
        var response = await httpClient.GetAsync(requestURL);
        if (printOutput)
        {
            var responseString = await response.Content.ReadAsStringAsync();
            PrintJsonToFile(responseString);
        }

        return response;
    }
    private async Task<HttpResponseMessage> PostAsync(HttpClient httpClient, string requestURL, object requestObject, bool printOutput = true)
    {
        var serializedRequestContent = JsonSerializer.Serialize(requestObject);
        var encodedRequestContent = new StringContent(serializedRequestContent, Encoding.UTF8, "application/json");
        var response = await httpClient.PostAsync(requestURL, encodedRequestContent);
        if (printOutput)
        {
            var responseString = await response.Content.ReadAsStringAsync();
            PrintJsonToFile(responseString);
        }

        return response;
    }
    private HttpClient CreateHttpClientWithHeaders(string authToken)
    {
        var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", authToken);
        return httpClient;
    }
    private void PrintJsonToFile(string json, string printPath = "response.json")
    {
        using var parsedJson = JsonDocument.Parse(json);
        var formatted = JsonSerializer.Serialize(parsedJson, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(printPath, formatted);
    }

    public async Task<string> GenerateNewAuthTokenAsync(string clientId, string clientSecret)
    {
        string requestURL = "https://api.tripleseat.com/oauth/token";

        var authRequest = new
        {
            client_id = clientId,
            client_secret = clientSecret,
            grant_type = "client_credentials"
        };

        using var httpClient = new HttpClient();
        var response = await PostAsync(httpClient, requestURL, authRequest);
        var responseObject = JsonSerializer.Deserialize<AuthResponse>(await response.Content.ReadAsStringAsync());
        if (responseObject == null || string.IsNullOrEmpty(responseObject.AccessToken)) throw new Exception("Failed to deserialize auth response");

        return responseObject.AccessToken;
    }
    public async Task InvalidateAuthTokenAsync(string authToken)
    {
        string requestURL = "https://api.tripleseat.com/oauth/invalidate";

        using var httpClient = CreateHttpClientWithHeaders(authToken);
        var response = await PostAsync(httpClient, requestURL, new { });
        var responseString = await response.Content.ReadAsStringAsync();
    }

    public async Task<List<Location>> GetLocationsAsync(string authToken)
    {
        string requestURL = "https://api.tripleseat.com/v1/locations.json";

        using var httpClient = CreateHttpClientWithHeaders(authToken);
        var response = await GetAsync(httpClient, requestURL);

        var responseString = await response.Content.ReadAsStringAsync();
        var responseObject = JsonSerializer.Deserialize<LocationResponse[]>(responseString);

        if (responseObject == null) throw new Exception("Failed to deserialize locations response");

        var debugJson = JsonSerializer.Serialize(responseObject);
        PrintJsonToFile(debugJson, "response1.json");

        var returnedLocations = responseObject.Where(lr => lr.Location != null).Select(lr => lr.Location!).ToList();
        return returnedLocations;
    }
    public async Task<List<Location>> GetLocationsAsync(string authToken, LocationsFilter locationsFilter)
    {
        string requestURL = "https://api.tripleseat.com/v1/locations.json";

        using var httpClient = CreateHttpClientWithHeaders(authToken);
        var response = await GetAsync(httpClient, requestURL);

        var responseString = await response.Content.ReadAsStringAsync();
        var responseObject = JsonSerializer.Deserialize<LocationResponse[]>(responseString);

        if (responseObject == null) throw new Exception("Failed to deserialize locations response");

        var debugJson = JsonSerializer.Serialize(responseObject);
        PrintJsonToFile(debugJson, "response1.json");

        var returnedLocations = responseObject.Where(lr => lr.Location != null).Select(lr => lr.Location!).ToList();
        return returnedLocations;
    }
    public async Task<Location> GetLocationByIdAsync(string authToken, int locationId)
    {
        string requestURL = $"https://api.tripleseat.com/v1/locations/{locationId}.json";

        using var httpClient = CreateHttpClientWithHeaders(authToken);
        var response = await GetAsync(httpClient, requestURL);

        var responseString = await response.Content.ReadAsStringAsync();
        var responseObject = JsonSerializer.Deserialize<LocationResponse>(responseString);

        if (responseObject == null) throw new Exception("Failed to deserialize location response");
        if (responseObject.Location == null) throw new Exception("Returned location was null");

        var debugJson = JsonSerializer.Serialize(responseObject);
        PrintJsonToFile(debugJson, "response1.json");

        return responseObject.Location;
    }

    public async Task<List<Event>> GetEventsAsync(string authToken)
    {
        int currentPage = 1;
        bool allEventsProcessed = false;
        List<Event> events = new List<Event>();
        using var httpClient = CreateHttpClientWithHeaders(authToken);

        while (!allEventsProcessed)
        {
            string requestURL = $"https://api.tripleseat.com/v1/events.json?page={currentPage}";
            var response = await GetAsync(httpClient, requestURL);

            var responseString = await response.Content.ReadAsStringAsync();
            var responseObject = JsonSerializer.Deserialize<MultiEventResponse>(responseString);

            if (responseObject == null) throw new Exception("Failed to deserialize events response");
            if (responseObject.Events == null) throw new Exception("Event list was null");
            if (responseObject.TotalPages == 0) return events;

            var returnedEvents = responseObject.Events.Where(e => e != null).Select(e => e!).ToList();
            events.AddRange(returnedEvents);

            if (currentPage == responseObject.TotalPages)
            {
                allEventsProcessed = true;
            }
            else
            {
                currentPage += 1;
            }
        }

        return events;
    }
    public async Task<List<Event>> GetEventsAsync(string authToken, EventsFilter eventsFilter)
    {
        var filterURL = eventsFilter.GenerateURLFromFilters();
        if (string.IsNullOrEmpty(filterURL)) return await GetEventsAsync(authToken);

        int currentPage = 1;
        bool allEventsProcessed = false;
        bool shouldOnlyReturnOnePage = eventsFilter.PageNumber != null;
        List<Event> events = new List<Event>();
        using var httpClient = CreateHttpClientWithHeaders(authToken);

        while (!allEventsProcessed)
        {
            string requestURL = $"https://api.tripleseat.com/v1/events/search.json{filterURL}";
            if (!shouldOnlyReturnOnePage) requestURL += $"&page={currentPage}";
            Console.WriteLine(requestURL);
            var response = await GetAsync(httpClient, requestURL);

            var responseString = await response.Content.ReadAsStringAsync();
            var responseObject = JsonSerializer.Deserialize<MultiEventResponse>(responseString);

            if (responseObject == null) throw new Exception("Failed to deserialize events response");
            if (responseObject.Events == null) throw new Exception("Event list was null");
            if (responseObject.TotalPages == 0) return events;

            var debugJson = JsonSerializer.Serialize(responseObject);
            PrintJsonToFile(debugJson, "response1.json");

            var returnedEvents = responseObject.Events.Where(e => e != null).Select(e => e!).ToList();
            events.AddRange(returnedEvents);

            if (currentPage == responseObject.TotalPages || shouldOnlyReturnOnePage)
            {
                allEventsProcessed = true;
            }
            else
            {
                currentPage += 1;
            }
        }

        return events;
    }
    public async Task<Event> GetEventByIdAsync(string authToken, int eventId)
    {
        string requestURL = $"https://api.tripleseat.com/v1/events/{eventId}.json";

        using var httpClient = CreateHttpClientWithHeaders(authToken);
        var response = await GetAsync(httpClient, requestURL);

        var responseString = await response.Content.ReadAsStringAsync();
        var responseObject = JsonSerializer.Deserialize<SingleEventResponse>(responseString);

        if (responseObject == null) throw new Exception("Failed to deserialize event response");
        if (responseObject.Event == null) throw new Exception("Returned event was null");

        var debugJson = JsonSerializer.Serialize(responseObject);
        PrintJsonToFile(debugJson, "response1.json");

        return responseObject.Event!;
    }
}